using Microsoft.EntityFrameworkCore;
using Project.Database;
using Project.Redact;

namespace Project.Forms
{
    public partial class MainForm : Form
    {
        private readonly Operator _currentOperator;
        private readonly AppDbContext _dbContext;
        private bool IsAdmin = false;

        public MainForm(Operator currentOperator, AppDbContext dbContext)
        {
            InitializeComponent();
            _currentOperator = currentOperator;
            _dbContext = dbContext;
            PopulateClientsComboBox();
            IsAdministrator();
        }

        private void IsAdministrator()
        {
            if (_currentOperator.Role != Role.Administrator)
            {
                var picket = _dbContext.Pickets
                    .Include(x => x.ProfilePoint)
                    .ThenInclude(xx => xx.Profile)
                    .ThenInclude(xxx => xxx.Area)
                    .ThenInclude(xxxx => xxxx.Project)
                    .ThenInclude(xxxxx => xxxxx.Customer)
                    .FirstOrDefault(s => s.PicketID == _currentOperator.PicketID);

                if (picket != null)
                {
                    cmbCustomer.Enabled = false;
                    cmbCustomer.Text = picket.ProfilePoint.Profile.Area.Project.Customer.CustomerName;
                    cmbProjects.Enabled = false;
                    cmbProjects.Text = picket.ProfilePoint.Profile.Area.Project.ProjectName;
                }

                dgvArea.ReadOnly = true;
                dgvProfilePoints.ReadOnly = true;
                dgvPickets.AllowUserToAddRows = false;
                dgvPickets.AllowUserToDeleteRows = false;
            }
            else
            {
                IsAdmin = true;
            }
        }

        private void PopulateClientsComboBox()
        {
            cmbCustomer.Items.AddRange(_dbContext.Customers.Select(c => c.CustomerName).ToArray());
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProjects.Text = null;
            cmbProjects.Items.Clear();
            dgvArea.Columns.Clear();
            dgvProfilePoints.Columns.Clear();
            dgvPickets.Columns.Clear();

            if (cmbCustomer.SelectedIndex != -1)
            {
                var selectedClient = _dbContext.Customers.FirstOrDefault(c => c.CustomerName == cmbCustomer.SelectedItem.ToString());
                if (selectedClient != null)
                {
                    cmbProjects.Items.AddRange(_dbContext.Projects.Where(p => p.CustomerID == selectedClient.CustomerID).Select(p => p.ProjectName).ToArray());
                }
            }
        }

        private void cmbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvArea.Columns.Clear();

            if (cmbProjects.SelectedIndex != -1)
            {
                var areas = _dbContext.Areas.Where(a => a.Project.ProjectName == cmbProjects.SelectedItem.ToString()).ToList();
                dgvArea.AutoGenerateColumns = false;

                dgvArea.DataSource = areas;
                dgvArea.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "AreaName",
                    HeaderText = "Area Name"
                });
            }
        }

        private void dgvArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProfilePoints.Columns.Clear();

            if (e.RowIndex >= 0 && dgvArea.Rows[e.RowIndex].DataBoundItem is Area selectedArea)
            {
                var profilePoints = _dbContext.ProfilePoints.Where(pp => pp.Profile.AreaID == selectedArea.AreaID).ToList();
                dgvProfilePoints.AutoGenerateColumns = false;
                dgvProfilePoints.DataSource = profilePoints;
                dgvProfilePoints.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "PointID",
                    HeaderText = "Point ID"
                });
            }
        }

        private void dgvProfilePoints_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPickets.Columns.Clear();

            if (e.RowIndex >= 0 && dgvProfilePoints.Rows[e.RowIndex].DataBoundItem is ProfilePoint selectedPP)
            {
                List<Picket> pickets;

                if (IsAdmin)
                {
                    pickets = _dbContext.Pickets
                        .Where(p => p.ProfilePointID == selectedPP.PointID)
                        .ToList();
                }
                else
                {
                    pickets = _dbContext.Pickets
                        .Where(p => p.ProfilePointID == selectedPP.PointID)
                        .Where(x => x.PicketID == _currentOperator.PicketID)
                        .ToList();
                }

                dgvPickets.AutoGenerateColumns = false;
                dgvPickets.DataSource = pickets;
                dgvPickets.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "XCoordinate",
                    HeaderText = "X"
                });
                dgvPickets.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "YCoordinate",
                    HeaderText = "Y"
                });
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            var profilePoints = _dbContext.ProfilePoints.ToArray();
            var pickets = _dbContext.Pickets.ToArray();
            var picketVal = _dbContext.PicketValues.ToArray();

            GraphForm frm = new(profilePoints, pickets, picketVal);
            frm.ShowDialog();
        }

        private void btnRedactCustomer_Click(object sender, EventArgs e)
        {
            var customer = _dbContext.Customers.ToList();
            RedactCustomer redactCustomer = new(customer, _dbContext);
            redactCustomer.ShowDialog();
        }

        private void btnRedactProject_Click(object sender, EventArgs e)
        {
            var customer = _dbContext.Customers.ToList();
            var project = _dbContext.Projects.ToList();
            RedactProject redactProject = new(project, customer, _dbContext);
            redactProject.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();

            LoginForm loginForm = new();
            loginForm.Show();
        }

        private void btnRedactProfilePoints_Click(object sender, EventArgs e)
        {
            var profilesPoints = _dbContext.ProfilePoints.ToList();
            var profiles = _dbContext.Profiles.ToList();
            RedactProfilePoints redactProfile = new(profilesPoints, profiles, _dbContext);
            redactProfile.ShowDialog();
        }

        private void btnRedactPickets_Click(object sender, EventArgs e)
        {
            var pickets = _dbContext.Pickets.ToList();
            var profilesPoints = _dbContext.ProfilePoints.ToList();
            RedactPickets redactPickets = new(profilesPoints, pickets, _dbContext);
            redactPickets.ShowDialog();
        }

        private void btnRedactArea_Click(object sender, EventArgs e)
        {
            var area = _dbContext.Areas.ToList();
            var project = _dbContext.Projects.ToList();
            RedactArea redactArea = new(area, project, _dbContext);
            redactArea.ShowDialog();
        }

        private void btnRedactProfilPP_Click(object sender, EventArgs e)
        {
            var area = _dbContext.Areas.ToList();
            var profiles = _dbContext.Profiles.ToList();
            RedactProfilPP redactArea = new(profiles, area, _dbContext);
            redactArea.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pickets = _dbContext.Pickets.ToList();
            var picketVal = _dbContext.PicketValues.ToList();

            RedactPicketValue redactPicketValue = new(pickets, picketVal, _dbContext);
            redactPicketValue.ShowDialog();
        }
    }
}
