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
        //Colors
        public static Color backColor = Color.FromArgb(235, 249, 247);//(247, 247, 249);
        public static Color secondColor = Color.FromArgb(37, 150, 132);//(114, 78, 87);//(57, 68, 125);
        public static Color thirdColor = Color.FromArgb(55, 183, 163);
        public static Color writingColor = Color.DarkSlateGray;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.Show();
            this.Opacity = 0;
            DateTime utcDate = DateTime.UtcNow;
            dateLabel.Text = utcDate.Date.ToShortDateString();
            DesignIt(this);
            label1.ForeColor = Color.DarkRed;
            label4.ForeColor = secondColor;
            pictureBox1.Image = Image.FromFile(Form1.projectPath+@"\health_professionals2.png");
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            doctorLabel.Text = "Welcome ";
            if (doctor != null)
            {
                doctorLabel.Text += doctor.Username();
            }
            HandleButtons();
            DesignIt(this);
            label1.ForeColor = Color.Green;
            label4.ForeColor = secondColor;
        }
        public static void DesignIt(Form form)
        {
            form.BackColor = backColor;
            form.ForeColor = Color.White;
            foreach (Control control in form.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).BackColor = secondColor;
                    ((Button)control).ForeColor = Color.White;
                    ((Button)control).FlatAppearance.BorderColor = thirdColor;
                    ((Button)control).FlatAppearance.BorderSize = 3;
                }
                if (control is Label)
                {
                    ((Label)control).ForeColor =Color.Black;
                }
                if (control is TextBox)
                {
                    ((TextBox)control).BackColor = Color.White;
                    ((TextBox)control).ForeColor = writingColor;
                    ((TextBox)control).BorderStyle = BorderStyle.Fixed3D;
                }
                if (control is RadioButton)
                {
                    ((RadioButton)control).ForeColor = writingColor;
                }
                if (control is ListView)
                {
                    ((ListView)control).BackColor = backColor;
                    ((ListView)control).ForeColor = writingColor;
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            doctor = null;
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


        private void HandleButtons()
        {
            if (doctor == null)
            {
                ButtonsState();
            }
            else
            {
                if (patient == null)
                {
                    ButtonsState(true);
                }
                else if (questions == null)
                {
                    ButtonsState(false, true);
                }
                else if (bloodTest == null)
                {
                    ButtonsState(false, false, true);
                }
                else if (bloodTest != null && questions != null && patient != null)
                {
                    ButtonsState(false, false, false, true);
                }
            }
        }

        private void ButtonsState(bool pat = false, bool ques = false, bool blood = false, bool res = false)
        {
            patientButton.Enabled = pat;
            questionButton.Enabled = ques;
            bloodTestButton.Enabled = blood;
            resultsButton.Enabled = res;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("EXCEL"))
            {
                process.Kill();
            }
        }

   
    }
}