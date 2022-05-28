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
    public partial class Register : Form
    {
        private Form1 form1;
        private bool isRegisterd = false;
        public Register(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msgError = "";
            if (Functions.IsUsernameLegal(userTextBox.Text) == false)
            {
                msgError += "username not legal\n";
            }
            if (Functions.IsPasswordLegal(passTextBox.Text) == false)
            {
                msgError += "password not legal\n";
            }
            if (Functions.IsIdLegal(idTextBox.Text) == false)
            {
                msgError += "id not legal\n";
            }
            if (msgError!="")
            {
                MessageBox.Show(msgError,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (Functions.GetUsernameIndex(userTextBox.Text) != -1)
                    {
                        MessageBox.Show("username already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }else if (Functions.IsIdExist(idTextBox.Text)==true){
                        MessageBox.Show("id already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Excel excel = new Excel(Form1.projectPath + Form1.accountsPath, 1);
                        try
                        {
                            excel.WriteLastRow(userTextBox.Text, passTextBox.Text, idTextBox.Text);
                            Form1.doctor = new Doctor(userTextBox.Text, passTextBox.Text);
                            form1.Opacity = 1;
                            form1.Focus();
                            isRegisterd = true;
                            Close();

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            excel.closeXl();
                        }
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isRegisterd == false)
            {
                Environment.Exit(0);

            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Form1.DesignIt(this);
            label4.ForeColor = Form1.secondColor;
        }
    }
}
