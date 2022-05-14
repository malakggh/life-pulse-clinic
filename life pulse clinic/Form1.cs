namespace life_pulse_clinic
{
    public partial class Form1 : Form
    {
        private string projectPath = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.IndexOf("\\bin"));
        private string accountsPath = "\\accountsTable.xlsx";
        public static Doctor doctor;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (doctor != null)
            {
                MessageBox.Show(doctor.Username());
            }
            else
            {
                MessageBox.Show("error!");
            }
        }
    }
}