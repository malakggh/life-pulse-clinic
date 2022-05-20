using System;
using System.Collections;
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
        public override ArrayList GetDisease()
        {
            diseases=new ArrayList();
            if (GetStatus()=="High")
            {
                diseases.Add("מחלת כבד");
                diseases.Add("מחלות בדרכי המרה");
                if (Form1.patient.GetGender()=="Female")
                {
                    diseases.Add("עלול להיות בהריון");
                }
                diseases.Add("פעילות יתר של בלוטת התריס");
                diseases.Add("שימוש בתרופות שונות");
                return diseases;
            }
            else if (GetStatus()=="Low")
            {
                diseases.Add("תת תזונה");
                diseases.Add("חוסר בוויטמינים");
                return diseases;
            }
            else
            {
                return null;
            }
        }
    }
}
