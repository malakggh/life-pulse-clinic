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
    public partial class BloodTestPage : Form
    {
        public BloodTestPage()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.bloodTest=new BloodTest(double.Parse(WBCTextBox.Text),double.Parse(NeutTextBox.Text),
                    double.Parse(LymphTextBox.Text), double.Parse(RBCTextBox.Text), double.Parse(HCTTextBox.Text),
                    double.Parse(UreaTextBox.Text), double.Parse(HbTextBox.Text), double.Parse(CrtnTextBox.Text),
                    double.Parse(IronTextBox.Text), double.Parse(HDLTextBox.Text), double.Parse(APTextBox.Text));

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BloodTestPage_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    ((Label)control).Text += ": ";

                }
            }
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Browse Excel File";
        }

        private void BloodTestPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ImportExcelButton_Click(object sender, EventArgs e)
        {
            string path;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
            else
            {
                path = "";
            }
            if (path != "")
            {

                Excel excel = new Excel(path, 1);
                try
                {
                    //while ()
                    //{
                    // 
                    //}

                }
                catch (Exception)
                {

                    MessageBox.Show("Error Occured While Checking If Password Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    excel.closeXl();
                }
            }

        }
    }
}
