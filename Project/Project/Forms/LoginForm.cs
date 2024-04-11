using Microsoft.EntityFrameworkCore;
using Project.Database;

namespace Project.Forms
{
    public partial class LoginForm : Form
    {
        private string _selectedConnectionString;

        public LoginForm()
        {
            InitializeComponent();
            cmbChange.Items.Add("Project");
            cmbChange.Items.Add("LazarevNE_107g2_Logging");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbChange.Text))
            {
                MessageBox.Show("Пожалуйста, выберите строку подключения.");
                return;
            }

            if (!string.IsNullOrEmpty(cmbChange.Text))
            {
                if (ckbCollege.Checked)
                {
                    _selectedConnectionString = $"Data Source=DBSRV\\AG2023; Initial Catalog={cmbChange.Text}; Integrated Security=true; Trusted_Connection=True; MultipleActiveResultSets=true; TrustServerCertificate=true;";
                }
                else
                {
                    _selectedConnectionString = $"Server=(local); Database={cmbChange.Text}; Trusted_Connection=True; Integrated Security=true; MultipleActiveResultSets=true; TrustServerCertificate=true;";
                }
            }

            using var dbContext = CreateDbContext();
            var currOperator = dbContext.Operators.FirstOrDefault(
                o => o.OperatorLogin == txbLogin.Text &&
                o.OperatorPassword == txbPassword.Text);

            if (currOperator != null)
            {
                this.Hide();
                MainForm mainForm = new(currOperator, dbContext);
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверные учетные данные.");
            }
        }

        private AppDbContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(_selectedConnectionString);
            return new AppDbContext(optionsBuilder.Options);
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
