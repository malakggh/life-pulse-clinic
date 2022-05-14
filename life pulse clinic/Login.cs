using System.Data;
//#include "Doctor"

namespace life_pulse_clinic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
       
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //1.check if username and password exists in excel file
            //2.if ture
            //...
            //3.else
            //...
            if (isUsernameAndPassVaild(userTextBox.Text, passTextBox.Text) == true)
            {
                Form1.doctor = new Doctor(userTextBox.Text, passTextBox.Text);
                Close();
            }
            else
            {

            }

        }

        private bool isUsernameAndPassVaild(string username,string password)
        {
            return true;
        }


    }
}
