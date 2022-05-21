using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace life_pulse_clinic
{
    public partial class PatientPage : Form
    {
        private Form1 form1; 
        public PatientPage(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            if (isTextBoxImbty() == false) { 
                MessageBox.Show("Fill All TextBoxes to Continue!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string gender = "";
                    if(femaleButton.Checked == true)
                    {
                        gender = "Female";
                    }
                    else
                    {
                        gender = "Male";
                    }
                    string errorMsg = "";
                    if (Functions.IsEmailLegal(emailTextBox.Text)==false)
                    {
                        errorMsg += "Email Addess is Not Vaild\n";
                    }
                    if (Functions.IsIdLegal(idTextBox.Text)==false)
                    {
                        errorMsg += "Id is Not Vaild\n";
                    }
                    if (Functions.IsAgeLegal(int.Parse(ageTextBox.Text)) == false)
                    {
                        errorMsg += "Age is Not In Range\n";
                    }
                    if (Functions.IsPhoneNumberLegal(phoneTextBox.Text) == false)
                    {
                        errorMsg += "Phone Number is Not Legal\n";
                    }
                    if (firstNameTextBox.TextLength < 3)
                    {
                        errorMsg += "First Name is Not Legal\n";
                    }
                    if (lastNameTextBox.TextLength < 3)
                    {
                        errorMsg += "Last Name is Not Legal\n";
                    }
                    if (cityTextBox.TextLength < 3)
                    {
                        errorMsg += "City Name is Not Legal\n";
                    }
                    if (errorMsg != "")
                    {
                        MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Form1.patient = new Patient(firstNameTextBox.Text, lastNameTextBox.Text
                            , idTextBox.Text, int.Parse(ageTextBox.Text),gender, cityTextBox.Text, phoneTextBox.Text
                            , emailTextBox.Text);
                        form1.Show();
                        Close();    

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private bool isTextBoxImbty()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    if(((TextBox)control).Text =="")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void PatientPage_Load(object sender, EventArgs e)
        {
            maleButton.Checked = true;
        }

        private void PatientPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Show();
        }
    }
}
