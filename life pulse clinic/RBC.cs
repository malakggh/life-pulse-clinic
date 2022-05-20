using System;
using System.Collections;
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
        public override ArrayList GetDisease()
        {
            diseases = new ArrayList();
            if (Form1.questions.GetSmoker())
            {
                diseases.Add("מעשנים");
            }
            if (GetStatus() == "High")
            {
                diseases.Add("הפרעה ביצירת הדם / תאי דם");
                diseases.Add("מחלת ריאות");
                return diseases;
            }else if(GetStatus() == "Low")
            {
                diseases.Add("אנמיה");
                diseases.Add("דימום");
                return diseases;
            }
            else
            {
                if (Form1.questions.GetSmoker())
                {
                    return diseases;
                }
                return null;
            }

        }
    }
}
