using Project.Database;

namespace Project.Redact
{
    public partial class RedactPickets : Form
    {
        private readonly List<Picket> _picket;
        private readonly List<ProfilePoint> _profilePoint;
        private readonly AppDbContext _appDbContext;
        public RedactPickets(List<ProfilePoint> profilePoints, List<Picket> pickets, AppDbContext appDbContext)
        {
            InitializeComponent();
            _picket = pickets;
            _profilePoint = profilePoints;
            _appDbContext = appDbContext;
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.Clear();
            foreach (var client in _picket)
            {
                comboBox1.Items.Add(client.PicketID);
            }
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Clear();
            foreach (var client in _profilePoint)
            {
                comboBox2.Items.Add(client.ProfileID);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var picket = _picket.FirstOrDefault(x => x.PicketID == (int)comboBox1.SelectedItem).PicketID;
            var profPId = _profilePoint.FirstOrDefault(x => x.ProfileID == (int)comboBox2.SelectedItem).PointID;

            if (!checkBox1.Checked)
            {
                Picket pickets = new()
                {
                    PicketID = picket,
                    ProfilePointID = profPId,
                    XCoordinate = int.Parse(textBox1.Text),
                    YCoordinate = int.Parse(textBox2.Text)
                };

                try
                {
                    _appDbContext.Pickets.Add(pickets);
                    _appDbContext.SaveChanges();
                    MessageBox.Show("Успешно создан.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
                }
            }
            else
            {
                Picket pickets = new()
                {
                    ProfilePointID = profPId,
                    XCoordinate = int.Parse(textBox1.Text),
                    YCoordinate = int.Parse(textBox2.Text)
                };

                try
                {
                    _appDbContext.Pickets.Add(pickets);
                    _appDbContext.SaveChanges();
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
