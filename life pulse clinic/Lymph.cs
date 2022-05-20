using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class Lymph : BloodTestX
    {
        private WBC wbc;
        public Lymph(double value,WBC wbc) : base(value)
        {
            this.wbc =wbc;
        }


        public override string GetStatus()
        {
            double WBCValue = wbc.GetValue();
            return GetRes(WBCValue * 0.36, WBCValue * 0.52);
        }
        public override ArrayList GetDisease()
        {
            diseases = new ArrayList();
            if (GetStatus() == "High")
            {
                diseases.Add("זיהום");
                diseases.Add("סרטן");
                return diseases; 
            }else if(GetStatus() == "Low")
            {
                diseases.Add("הפרעה ביצירת הדם / תאי דם");
                return diseases;
            }
            else
            {
                return null;
            }
        }

    }
}
