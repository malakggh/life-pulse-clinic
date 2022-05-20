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
        private bool pregnant;
        public Questions(bool ethiopian, bool eastern, bool smoker, bool fever, bool pregnant)
        {
            this.ethiopian = ethiopian;
            this.eastern = eastern;
            this.smoker = smoker;
            this.fever = fever;
            this.pregnant = pregnant;
        }

        public bool GetEthiopian() { return ethiopian; }
        public bool GetEastern() { return eastern; }
        public bool GetSmoker() { return smoker; }
        public bool GetFever() { return fever; }
        public bool Getpregnant() { return pregnant; }
    }
}
