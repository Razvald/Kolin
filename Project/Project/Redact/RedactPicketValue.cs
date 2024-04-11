using Project.Database;

namespace Project.Redact
{
    public partial class RedactPicketValue : Form
    {
        private readonly List<PicketValue> _picketsVal;
        private readonly List<Picket> _pickets;
        private readonly AppDbContext _appDbContext;
        public RedactPicketValue(List<Picket> pickets, List<PicketValue> picketValues, AppDbContext appDbContext)
        {
            InitializeComponent();
            _appDbContext = appDbContext;
            _pickets = pickets;
            _picketsVal = picketValues;
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.Clear();
            foreach (var client in _picketsVal)
            {
                comboBox1.Items.Add(client.PicketValueID);
            }
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Clear();
            foreach (var client in _pickets)
            {
                comboBox2.Items.Add(client.PicketID);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var picketVal = _picketsVal.FirstOrDefault(x => x.PicketValueID == (int)comboBox1.SelectedItem).PicketValueID;
            var picket = _pickets.FirstOrDefault(x => x.PicketID == (int)comboBox2.SelectedItem).PicketID;

            if (!checkBox1.Checked)
            {
                PicketValue pickets = new()
                {
                    PicketValueID = picketVal,
                    PicketID = picket,
                    HValue = int.Parse(textBox2.Text),
                    Amplitude = int.Parse(comboBox1.Text)
                };

                try
                {
                    _appDbContext.PicketValues.Add(pickets);
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
                PicketValue pickets = new()
                {
                    PicketID = picket,
                    HValue = int.Parse(textBox2.Text),
                    Amplitude = int.Parse(comboBox1.Text)
                };

                try
                {
                    _appDbContext.PicketValues.Add(pickets);
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
