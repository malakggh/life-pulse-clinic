using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class Ap : BloodTestX
    {
        public Ap(double value) : base(value)
        {
        }

        public override string GetStatus()
        {
            bool questionIsEthiopain = Form1.questions.GetEthiopian();
            if (questionIsEthiopain == false)
            {
                return GetRes(30, 90);
            }
            else
            {
                return GetRes(60, 120);
            }
        }
    }
}
