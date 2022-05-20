using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class Crtn : BloodTestX
    {
        public Crtn(double value) : base(value)
        {
        }


        public override string GetStatus()
        {
            int age = Form1.patient.GetAge();
            if (age >= 0 && age <=2)
            {
                return GetRes(0.2, 0.5);
            }else if(age>=3 && age <= 17)
            {
                return GetRes(0.5,1);
            }
            else if (age >= 18 && age <= 59)
            {
                return GetRes(0.6,1);
            }
            else
            {
                return GetRes(0.6,1.2);
            }
        }
        public override ArrayList GetDisease()
        {
            diseases = new ArrayList();
            if(GetStatus() == "High")
            {
                diseases.Add("מחלת כליה");
                diseases.Add("מחלות שריר");
                diseases.Add("צריכה מוגברת של בשר");
                return diseases;
            }
            else if(GetStatus() == "Low")
            {
                diseases.Add("מחלות שריר");
                diseases.Add("תת תזונה");
                return diseases;
            }
            else
            {
                return null;
            }
        }
    }
}
