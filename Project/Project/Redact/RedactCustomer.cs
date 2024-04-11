using Project.Database;

namespace Project.Redact
{
    public partial class RedactCustomer : Form
    {
        private readonly List<Customer> _customer;
        private readonly AppDbContext _dbContext;
        public RedactCustomer(List<Customer> customers, AppDbContext appDbContext)
        {
            InitializeComponent();
            _customer = customers;
            _dbContext = appDbContext;
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.Clear();
            foreach (var client in _customer)
            {
                comboBox1.Items.Add(client.CustomerName);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var custId = _customer.FirstOrDefault(x => x.CustomerName == comboBox1.Text).CustomerID;

            if (!checkBox1.Checked)
            {
                Customer customer = new()
                {
                    CustomerID = custId,
                    CustomerName = textBox1.Text,
                    Email = textBox2.Text
                };

                try
                {
                    _dbContext.Customers.Add(customer);
                    _dbContext.SaveChanges();
                    MessageBox.Show("Успешно создан.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
                }
            }
            else
            {
                Customer customer = new()
                {
                    CustomerName = textBox1.Text,
                    Email = textBox2.Text
                };

                try
                {
                    _dbContext.Customers.Add(customer);
                    _dbContext.SaveChanges();
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