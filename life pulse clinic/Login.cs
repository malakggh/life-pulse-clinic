using System.Data;
//#include "Doctor"

namespace life_pulse_clinic
{
    public partial class Login : Form
    {
        private Doctor doctor;
        public Login(ref Doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //98fjdifdl
            this.doctor = new Doctor("malak", "2312");

        }

    }
}
