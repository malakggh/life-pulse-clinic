using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class HDL : BloodTestX
    {
        public HDL(double value) : base(value)
        {
        }

        public override string GetStatus()
        {
            bool questionIsEthiopain=false;
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
                    return GetRes(29*1.2, 62*1.2);
                }
                else
                {
                    return GetRes(34*1.2, 82*1.2);
                }
            }
        }
    }
}
