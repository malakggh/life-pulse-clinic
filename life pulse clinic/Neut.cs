using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    internal class Neut : BloodTestX
    {
        private WBC wbc; 
        public Neut(double value,WBC wbc) : base(value)
        {
            this.wbc = wbc;
        }

        public override string GetStatus()
        {
            double WBCValue = wbc.GetValue();
            double NeutValue = GetValue();
            if(NeutValue< WBCValue * 0.28)
            {
                return "Low";
            }
            else if (NeutValue > WBCValue * 0.54)
            {
                return "High";
            }
            else
            {
                return "Normal";
            }
        }
    }
}
