using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class Urea : BloodTestX
    {
        
        public Urea(double value) : base(value)
        {
        }

        public override string GetStatus()
        {
             bool questionIsEastern=true;
            if (questionIsEastern == false)
            {
                return GetRes(17, 43);
            }
            else
            {
                return GetRes(17, 43 * 1.1);

            }

        }
    }
}
