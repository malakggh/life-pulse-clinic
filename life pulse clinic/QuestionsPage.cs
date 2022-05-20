﻿using System;
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
        public QuestionsPage()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            bool isEastern=false,isEthiopian=false,isSmoker=false,hasFever=false;
            if (easternRadioButton.Checked)
                isEastern = true;
            if (ethiopianRadioButton.Checked)
                isEthiopian = true;
            if (smokerRadioButton.Checked)
                isSmoker = true;
            if(feverRadioButton.Checked)
                hasFever = true;
            Form1.questions=new Questions(isEthiopian,isEastern,isSmoker,hasFever);
            Close();
        }
    }
}   
