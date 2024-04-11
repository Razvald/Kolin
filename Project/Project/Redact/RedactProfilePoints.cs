using Project.Database;
using ScottPlot.Colormaps;

namespace Project.Redact
{
    public partial class RedactProfilePoints : Form
    {
        private readonly List<ProfilePoint> _profilePoint;
        private readonly List<Profile> _profile;
        private readonly AppDbContext _context;
        public RedactProfilePoints(List<ProfilePoint> profilePoints, List<Profile> profiles, AppDbContext appDbContext)
        {
            InitializeComponent();
            _profile = profiles;
            _profilePoint = profilePoints;
            _context = appDbContext;
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.Clear();
            foreach (var client in _profilePoint)
            {
                comboBox1.Items.Add(client.ProfileID);
            }
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Clear();
            foreach (var client in _profile)
            {
                comboBox2.Items.Add(client.ProfileID);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var profId = _profile.FirstOrDefault(x => x.ProfileID == (int)comboBox2.SelectedItem).ProfileID;
            var profPId = _profilePoint.FirstOrDefault(x => x.PointID == (int)comboBox1.SelectedItem).PointID;

            if (!checkBox1.Checked)
            {
                /*ProfilePoint profilePoint = new()
                {
                    PointID = profPId,
                    ProfileID = profId,
                    XCoordinate = double.Parse(textBox1.Text),
                    YCoordinate = double.Parse(textBox2.Text)
                };

                try
                {
                    _context.ProfilePoints.Add(profilePoint);
                    _context.SaveChanges();
                    MessageBox.Show("Успешно создан.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
                }*/
            }
            else
            {
                ProfilePoint profilePoint = new()
                {
                    ProfileID = profId,
                    XCoordinate = double.Parse(textBox1.Text),
                    YCoordinate = double.Parse(textBox2.Text)
                };

                try
                {
                    _context.ProfilePoints.Add(profilePoint);
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
