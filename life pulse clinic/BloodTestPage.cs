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
        }
    }
}
