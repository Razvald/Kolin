using Project.Database;

namespace Project.Redact
{
    public partial class RedactProfilPP : Form
    {
        private readonly List<Profile> _profiles;
        private readonly List<Area> _area;
        private readonly AppDbContext _context;
        public RedactProfilPP(List<Profile> profiles, List<Area> areas, AppDbContext appDbContext)
        {
            InitializeComponent();
            _profiles = profiles;
            _area = areas;
            _context = appDbContext;
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.Clear();
            foreach (var client in _profiles)
            {
                comboBox1.Items.Add(client.ProfileID);
            }
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Clear();
            foreach (var client in _area)
            {
                comboBox2.Items.Add(client.AreaName);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var profId = _profiles.FirstOrDefault(x => x.ProfileID == (int)comboBox1.SelectedItem).ProfileID;
            var areaId = _area.FirstOrDefault(x => x.AreaName == comboBox2.Text).AreaID;

            if (!checkBox1.Checked)
            {
                Profile profile = new()
                {
                    ProfileID = profId,
                    AreaID = areaId
                };

                try
                {
                    _context.Profiles.Add(profile);
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
                Profile profile = new()
                {
                    AreaID = areaId
                };

                try
                {
                    _context.Profiles.Add(profile);
                    _context.SaveChanges();
                    MessageBox.Show("Успешно создан.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных: {ex.InnerException.Message}");
                }
            }
        }
    }
}
