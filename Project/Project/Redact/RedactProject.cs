using Microsoft.EntityFrameworkCore;
using Project.Database;

namespace Project.Redact
{
    public partial class RedactProject : Form
    {
        private readonly List<Database.Project> _project;
        private readonly List<Customer> _customer;
        private readonly AppDbContext _context;

        public RedactProject(List<Database.Project> project, List<Customer> customers, AppDbContext context)
        {
            InitializeComponent();
            _project = project;
            _customer = customers;
            _context = context;
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.Clear();
            foreach (var client in _project)
            {
                comboBox1.Items.Add(client.ProjectName);
            }
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Clear();
            foreach (var client in _customer)
            {
                comboBox2.Items.Add(client.CustomerName);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var projId = _project.FirstOrDefault(x => x.ProjectName == comboBox1.Text).ProjectID;
            var custId = _customer.FirstOrDefault(x => x.CustomerName == comboBox2.Text).CustomerID;

            if (!checkBox1.Checked)
            {
                Database.Project project = new()
                {
                    ProjectID = projId,
                    Location = textBox2.Text,
                    ProjectName = textBox1.Text,
                    CustomerID = custId
                };

                try
                {
                    _context.Projects.Add(project);
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
                Database.Project project = new()
                {
                    Location = textBox2.Text,
                    ProjectName = textBox1.Text,
                    CustomerID = custId
                };

                try
                {
                    _context.Projects.Add(project);
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
/*
    public class Project
{
    public int ProjectID { get; set; }
    public string? ProjectName { get; set; }
    public string? Location { get; set; }

    [ForeignKey("Customer")]
    public int CustomerID { get; set; }
}*/