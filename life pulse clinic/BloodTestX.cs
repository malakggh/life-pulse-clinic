using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public abstract class BloodTestX
    {
        private double value;

        protected BloodTestX(double value) { this.value = value; }
        public abstract string GetStatus();

        public double GetValue() { return value; }
    }
}
