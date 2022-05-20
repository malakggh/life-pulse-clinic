using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class Neut : BloodTestX
    {
        private WBC wbc; 
        public Neut(double value,WBC wbc) : base(value)
        {
            this.wbc = wbc;
        }


        public override string GetStatus()
        {
            double WBCValue = wbc.GetValue();
            return GetRes(WBCValue*0.28, WBCValue*0.54);
        }
        public override ArrayList GetDisease()
        {
            diseases = new ArrayList();
            if (GetStatus()=="High")
            {
                diseases.Add("זיהום");
                return diseases;    
            }else if (GetStatus() == "Low")
            {
                diseases.Add("הפרעה ביצירת הדם / תאי דם");
                diseases.Add("זיהום");
                diseases.Add("במקרים נדירים ביותר על סרטן");
                return diseases;
            }
            else
            {
                return null;
            }
        }
    }
}
