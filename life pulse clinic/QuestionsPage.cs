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
            bool isEastern=false,isEthiopian=false,isSmoker=false,hasFever=false,isPregnant=false;
            if (easternRadioButton.Checked)
                isEastern = true;
            if (ethiopianRadioButton.Checked)
                isEthiopian = true;
            if (smokerRadioButton.Checked)
                isSmoker = true;
            if(feverRadioButton.Checked)
                hasFever = true;
            if(pregnentRadioButton.Checked)
                isPregnant = true;
            Form1.questions=new Questions(isEthiopian,isEastern,isSmoker,hasFever,isPregnant);
            form1.Show();
            Close();

        }

        private void QuestionsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Show();
        }
    }
}   
