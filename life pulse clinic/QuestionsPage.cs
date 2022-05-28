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
    public partial class QuestionsPage : Form
    {
        private Form1 form1;
        public QuestionsPage(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            bool isEastern = false, isEthiopian = false, isSmoker = false, hasFever = false, isPregnant = false;
            if (comboBox1.SelectedIndex == 0)
                isEastern = true;
            if (comboBox1.SelectedIndex == 1)
                isEthiopian = true;
            if (comboBox2.SelectedIndex == 0)
                isSmoker = true;
            if (comboBox3.SelectedIndex == 0)
                hasFever = true;
            if (comboBox4.SelectedIndex == 0)
                isPregnant = true;
            //MessageBox.Show(isEthiopian + " " + isEastern + " " + isSmoker + " " + hasFever + " " + isPregnant);
            Form1.questions = new Questions(isEthiopian, isEastern, isSmoker, hasFever, isPregnant);
            form1.Show();
            form1.Focus();
            Close();

        }

        private void QuestionsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Show();
            form1.Focus();
        }

        private void QuestionsPage_Load(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }
            Form1.DesignIt(this);
        }
    }
}   
