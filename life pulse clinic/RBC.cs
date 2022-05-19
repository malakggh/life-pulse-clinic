using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class RBC : BloodTestX
    {
        public RBC(double value) : base(value)
        {
        }

        public override string GetStatus()
        {
            return GetRes(4.5, 6);
        }
    }
}
