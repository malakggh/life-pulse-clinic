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

        public static int GetUsernameIndex(string username)
        {
            Excel excel = new Excel(Form1.projectPath + Form1.accountsPath, 1);
            try
            {
                int index = 0;
                while (true)
                {
                    string str = excel.ReadCell(index, 0);
                    if (str == username)
                    {
                        return index;
                    }
                    else if (str == "")
                    {
                        return -1;
                    }
                    index++;
                }

            }
            catch (Exception)
            {
                throw new Exception("Error Occured While Checking If User Exist");
            }
            finally
            {
                excel.closeXl();
            }
        }
        public static bool IsIdExist(string id)
        {
            Excel excel = new Excel(Form1.projectPath + Form1.accountsPath, 1);
            try
            {
                int index = 0;
                while (true)
                {
                    string str = excel.ReadCell(index, 2);
                    if (str == id)
                    {
                        return true;
                    }
                    else if (str == "")
                    {
                        return false;
                    }
                    index++;
                }

            }
            catch (Exception)
            {
                throw new Exception("Error Occured While Checking If Id Exist");
            }
            finally
            {
                excel.closeXl();
            }
        }
        public static bool IsPasswordMatch(int userIndex, string password)
        {
            Excel excel = new Excel(Form1.projectPath + Form1.accountsPath, 1);
            try
            {
                if (excel.ReadCell(userIndex,1) == password)
                {
                    return true;
                }
                return false;

            }
            catch (Exception)
            {

                throw new Exception("Error Occured While Checking If Password Match");
            }
            finally
            {
                excel.closeXl();
            }
        }
        public static bool IsUsernameLegal(string username)
        {
            if (username.Length < 6)
                return false;
            if (username.Length > 8)
                return false;
            int integerCounter = 0;
            for (int i = 0; i < username.Length; i++)
            {
                if (username[i]>='0' && username[i]<='9')
                {
                    integerCounter++;
                }
            }
            if (integerCounter > 2)
                return false;
            return true;
        }
        public static bool IsPasswordLegal(string password)
        {
            if (password.Length < 8)
                return false;
            if (password.Length > 10)
                return false;
            bool containsInteger = false;
            bool containsLetter = false;
            bool containsSpeacial = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    containsInteger = true;
                }else if ((password[i] >= 'a' && password[i] <= 'z')||(password[i] >= 'A' && password[i] <= 'Z')) 
                {
                    containsLetter = true;
                }
                else
                {
                    containsSpeacial = true;
                }
            }
            return containsInteger && containsLetter && containsSpeacial;
        }
        public static bool IsIdLegal(string id)
        {
            if(id.Length != 9)
            {
                return false;
            }
            for(int i = 0; i < id.Length; i++)
            {
                if (!(id[i] >= '0' && id[i] <= '9')) 
                {
                    return false;
                }
            }
            return true;
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

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BloodTestPage bloodTestPage = new BloodTestPage();
            bloodTestPage.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PatientPage patientPage = new PatientPage();
            patientPage.Show();
        }
    }
}