using System;
using System.Collections;
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
            if (Form1.patient.GetAge() >=0 && Form1.patient.GetAge() <=17)
            {
                return GetRes(11.5, 15.5);
            }
            else if (Form1.patient.GetGender()=="Female")
            {
                return GetRes(12, 16);
            }else
            {
                return GetRes(12, 18);
            }
        }
        public override ArrayList GetDisease()
        {
            diseases = new ArrayList();
            if (GetStatus() == "Low")
            {
                diseases.Add("אנמיה");
                diseases.Add("הפרעה המטולוגית");
                diseases.Add("מחסור בברזל");
                diseases.Add("דימום");
                return diseases;
            }
            else
            {
                return null;
            }
        }
    }
}
