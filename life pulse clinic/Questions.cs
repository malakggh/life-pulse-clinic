using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    internal class Questions
    {
        private bool ethiopian;
        private bool easter;
        private bool smoker;
    }
    public Questions (bool ethiopian,bool easter,bool smoker)
    {
        this.ethiopian = ethiopian;  
        this.easter = easter;
        this.smoker = smoker;
    }
}
