using System.Diagnostics;
namespace life_pulse_clinic
{
    public partial class Form1 : Form
    {
        public static string projectPath = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.IndexOf("\\bin"));
        public static string accountsPath = "\\accountsTable.xlsx";
        public static Doctor doctor;
        public static Patient patient;
        public static BloodTest bloodTest;
        public static Questions questions;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doctor = null;
            Login login = new Login(this);
            login.Show();
            this.Opacity = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(IsPasswordLeagel("12356dxxqd").ToString());
            //Excel excel = new Excel(Form1.projectPath + Form1.accountsPath, 1);
            //MessageBox.Show(excel.ReadCell(0,0));
            //MessageBox.Show(excel.ReadCell(1, 0));
            //excel.closeXl();
            if (doctor != null)
            {
                MessageBox.Show(doctor.Username());
            }
            else
            {
                MessageBox.Show("error!");
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("EXCEL"))
            {
                //MessageBox.Show(process.ProcessName);
                //// Temp is a document which you need to kill.
                //if (process.MainWindowTitle.Contains("Temp"))
                process.Kill();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.Show();
            this.Opacity = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BloodTestPage bloodTestPage = new BloodTestPage(this);
            this.Hide();
            bloodTestPage.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PatientPage patientPage = new PatientPage(this);
            this.Hide();
            patientPage.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QuestionsPage questionsPage = new QuestionsPage(this);
            this.Hide();
            questionsPage.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResultPage resultPage = new ResultPage(this);
            this.Hide();
            resultPage.Show();
        }
    }
}