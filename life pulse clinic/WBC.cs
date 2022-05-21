using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class WBC : BloodTestX
    {
        
        public WBC(double value) : base(value)
        {
        }

        public override string GetStatus()
        {
            int age = Form1.patient.GetAge();
            if (age >= 0 && age <= 3)
            {
                return GetRes(6000, 17500);
            }else if(age >= 4 && age <= 17)
            {
                return GetRes(5500, 15500);
            }
            else if(age >= 18)
            {
                return GetRes(4500, 11000);
            }
            throw new Exception("Age Out of Range");
        }

        public override ArrayList GetDisease()
        {
            diseases = new ArrayList();
            if (GetStatus()=="High")
            {
                if (Form1.questions.GetFever())
                {
                    diseases.Add("זיהום");
                }
                else
                {
                    diseases.Add("מחלת דם");
                    diseases.Add("סרטן");
                }
                return diseases;
            }
            else if(GetStatus()=="Low")
            {
                diseases.Add("מחלה ויראלית");
                diseases.Add("כשל של מערכת החיסון");
                diseases.Add("סרטן");
                return diseases;
            }
            else
            {
                return null;
            }
        }
    }
}
