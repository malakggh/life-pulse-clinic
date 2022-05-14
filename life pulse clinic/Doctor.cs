using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
     public class Doctor
    {
        private string username;
        private string password;
        public Doctor(string username,string password)
        {
            this.username = username;
            this.password = password;
        }
        public string Username { get;}
        public string Password { get; }
    }
}
