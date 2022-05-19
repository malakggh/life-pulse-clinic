using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class Iron : BloodTestX
    {
        public Iron(double value) : base(value)
        {
        }

        public override string GetStatus()
        {
            if (Form1.patient.GetGender()=="Female")
            {
                return GetRes(60*0.8,160);
            }
            else
            {
                return GetRes(60,160);
            }
        }
    }
}
