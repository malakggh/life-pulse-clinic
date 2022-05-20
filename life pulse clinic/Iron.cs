using System;
using System.Collections;
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
                return GetRes(60*0.8,160*0.8);
            }
            else
            {
                return GetRes(60,160);
            }
        }
        public override ArrayList GetDisease()
        {
            diseases = new ArrayList();
            if (GetStatus()=="High")
            {
                diseases.Add("הרעלת ברזל");
                return diseases;
            }
            else if (GetStatus()=="Low")
            {
                diseases.Add("תת תזונה");
                diseases.Add("דימום");
                diseases.Add("עלול להיות בהריון");
                return diseases;
            }
            else
            {
                return null;
            }
        }
    }
}
