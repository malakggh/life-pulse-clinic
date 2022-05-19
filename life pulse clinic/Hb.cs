using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class Hb : BloodTestX
    {
        public Hb(double value) : base(value)
        {
        }

        public override string GetStatus()
        {
            //double value = GetValue();
            if (Form1.patient.GetAge() >=0 && Form1.patient.GetAge() <=17)
            {
                return GetRes(11.5, 15.5);
                //if (value < 11.5)
                //{
                //    return "Low";
                //}
                //else if (value > 15.5)
                //{
                //    return "High";
                //}
                //else
                //{
                //    return "Normal";
                //}
            }
            if (Form1.patient.GetGender()=="Female")
            {
                return GetRes(12, 16);
                //if (value < 12)
                //{
                //    return "Low";
                //}
                //else if (value > 16)
                //{
                //    return "High";
                //}
                //else
                //{
                //    return "Normal";
                //}
            }else
            {
                return GetRes(12, 18);
                //if (value < 12)
                //{
                //    return "Low";
                //}
                //else if (value > 18)
                //{
                //    return "High";
                //}
                //else
                //{
                //    return "Normal";
                //}
            }
        }
    }
}
