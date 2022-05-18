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
        public PatientPage()
        {
            InitializeComponent();
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
                    Form1.patient = new Patient(firstNameTextBox.Text, lastNameTextBox.Text
                        , idTextBox.Text, int.Parse(ageTextBox.Text),gender, cityTextBox.Text, phoneTextBox.Text
                        , emailTextBox.Text);
                    Close();    

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
    }
}
