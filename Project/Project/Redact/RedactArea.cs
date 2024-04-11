using Project.Database;

namespace Project.Redact
{
    public partial class RedactArea : Form
    {
        private readonly List<Area> _area;
        private readonly List<Database.Project> _project;
        private readonly AppDbContext _context;
        public RedactArea(List<Area> areas, List<Database.Project> projects, AppDbContext appDbContext)
        {
            InitializeComponent();
            _area = areas;
            _project = projects;
            _context = appDbContext;
            InitializeComboBox();
        }
        
        private void InitializeComboBox()
        {
            comboBox1.Items.Clear();
            foreach (var client in _area)
            {
                comboBox1.Items.Add(client.AreaName);
            }
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Clear();
            foreach (var client in _project)
            {
                comboBox2.Items.Add(client.ProjectName);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var areaId = _area.FirstOrDefault(x => x.AreaName == comboBox1.Text).AreaID;
            var projId = _project.FirstOrDefault(x => x.ProjectName == comboBox2.Text).ProjectID;

            if (!checkBox1.Checked)
            {
                Area area = new()
                {
                    AreaID = areaId,
                    AreaName = textBox1.Text,
                    ProjectID = projId
                };

                try
                {
                    _context.Areas.Add(area);
                    _context.SaveChanges();
                    MessageBox.Show("Успешно создан.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
                }
            }
            else
            {
                Area area = new()
                {
                    AreaName = textBox1.Text,
                    ProjectID = projId
                };

                try
                {
                    _context.Areas.Add(area);
                    _context.SaveChanges();
                    MessageBox.Show("Успешно создан.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
                }
            }
        }
    }
}
