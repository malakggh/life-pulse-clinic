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
            string errorMsg = "";
            if (Functions.IsUsernameLegal(userTextBox.Text) == false)
            {
                errorMsg += "username is not legal\n";
            }
            if (Functions.IsPasswordLegal(passTextBox.Text) == false)
            {
                errorMsg += "password is not legal\n";
            }
            if (errorMsg!="")
            {
                MessageBox.Show(errorMsg,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int userIndex = Functions.GetUsernameIndex(userTextBox.Text);
                    if (userIndex != -1)
                    {
                        if (Functions.IsPasswordMatch(userIndex, passTextBox.Text) == true)
                        {
                            Form1.doctor=new Doctor(userTextBox.Text, passTextBox.Text);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("password doesn't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("username doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            Close();
        }
    }
}
