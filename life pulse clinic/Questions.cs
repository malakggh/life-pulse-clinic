using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class Questions
    {
        private bool ethiopian;
        private bool eastern;
        private bool smoker;
        private bool fever;
        public Questions (bool ethiopian,bool eastern,bool smoker,bool fever)
        {
            this.ethiopian = ethiopian;  
            this.eastern = eastern;
            this.smoker = smoker;
            this.fever = fever;
        }

        public bool GetEthiopian() { return ethiopian; }
        public bool GetEastern() { return eastern; }
        public bool GetSmoker() { return smoker; }
        public bool GetFever() { return fever; }
    }
}
