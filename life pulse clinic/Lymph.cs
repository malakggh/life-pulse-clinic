using System;
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
            //double LymphValue = GetValue();
            return GetRes(WBCValue * 0.36, WBCValue * 0.52);
            //if (LymphValue < WBCValue * 0.36)
            //{
            //    return "Low";
            //}
            //else if (LymphValue > WBCValue * 0.52)
            //{
            //    return "High";
            //}
            //else
            //{
            //    return "Normal";
            //}
        }
    }
}
