using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class HDL : BloodTestX
    {
        private bool questionIsEthiopain;
        public HDL(double value) : base(value)
        {
            this.questionIsEthiopain = false;
        }

        public override string GetStatus()
        {
            if (questionIsEthiopain==false)
            {
                if (Form1.patient.GetGender()=="Male")
                {
                    return GetRes(29, 62);
                }
                else
                {
                    return GetRes(34, 82);
                }
            }
            else
            {
                if (Form1.patient.GetGender() == "Male")
                {
                    return GetRes(29, 62*1.2);
                }
                else
                {
                    return GetRes(34, 82*1.2);
                }
            }
        }
    }
}
