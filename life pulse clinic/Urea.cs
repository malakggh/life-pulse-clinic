using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class Urea : BloodTestX
    {
        
        public Urea(double value) : base(value)
        {
        }


        public override string GetStatus()
        {
            bool questionIsEastern = Form1.questions.GetEastern();
            if (questionIsEastern == false)
            {
                return GetRes(17, 43);
            }
            else
            {
                return GetRes(17*1.1, 43 * 1.1);

            }

        }
        public override ArrayList GetDisease()
        {
            diseases = new ArrayList();
            if(GetStatus() == "High")
            {
                diseases.Add("מחלת כליה");
                diseases.Add("התייבשות");
                diseases.Add("דיאטה");
                return diseases;
            }
            else if(GetStatus() == "Low")
            {
                if(Form1.patient.GetGender() == "Female" && Form1.questions.Getpregnant()) 
                {
                    return null;
                }
                else
                {
                    diseases.Add("תת תזונה");
                    diseases.Add("דיאטה");
                    diseases.Add("מחלת כבד");
                    return diseases;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
