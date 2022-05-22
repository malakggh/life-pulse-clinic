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
        private Form1 form1;
        public BloodTestPage(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.bloodTest=new BloodTest(double.Parse(WBCTextBox.Text),double.Parse(NeutTextBox.Text),
                    double.Parse(LymphTextBox.Text), double.Parse(RBCTextBox.Text), double.Parse(HCTTextBox.Text),
                    double.Parse(UreaTextBox.Text), double.Parse(HbTextBox.Text), double.Parse(CrtnTextBox.Text),
                    double.Parse(IronTextBox.Text), double.Parse(HDLTextBox.Text), double.Parse(APTextBox.Text));
                form1.Show();
                form1.Focus();
                Close();
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
                try
                {
                    Excel excel = new Excel(path, 1);
                    try
                    {
                        bool flag = true;
                        int i = 0;
                        while (flag)
                        {
                            string cell = excel.ReadCell(0, i);
                            if (cell.ToLower() == "wbc")
                            {
                                WBCTextBox.Text = excel.ReadCell(1, i);
                            }else if (cell.ToLower() == "neut")
                            {
                                NeutTextBox.Text=excel.ReadCell(1, i);
                            }else if(cell.ToLower() == "lymph")
                            {
                                LymphTextBox.Text=excel.ReadCell(1,i);
                            }else if (cell.ToLower() == "rbc")
                            {
                                RBCTextBox.Text=excel.ReadCell(1,i);
                            }else if(cell.ToLower() == "hct")
                            {
                                HCTTextBox.Text = excel.ReadCell(1, i);
                            }else if(cell.ToLower() == "urea")
                            {
                                UreaTextBox.Text = excel.ReadCell(1, i);
                            }else if(cell.ToLower() == "hb")
                            {
                                HbTextBox.Text=excel.ReadCell (1, i);
                            }else if (cell.ToLower() == "crtn")
                            {
                                CrtnTextBox.Text = excel.ReadCell(1, i);
                            }else if (cell.ToLower() == "iron")
                            {
                                IronTextBox.Text = excel.ReadCell(1, i);
                            }else if (cell.ToLower() == "hdl")
                            {
                                HDLTextBox.Text=excel.ReadCell(1, i);
                            }else if (cell.ToLower() == "ap")
                            {
                                APTextBox.Text = excel.ReadCell(1, i);
                            }else if(cell == "")
                            {
                                flag = false;
                            }
                            i++;
                        }

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error Occured While Reading File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        excel.closeXl();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BloodTestPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Show();
            form1.Focus();
        }
    }
}
