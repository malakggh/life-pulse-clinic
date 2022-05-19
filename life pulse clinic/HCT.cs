using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class HCT : BloodTestX
    {
        private RBC rbc;
        public HCT(double value,RBC rbc) : base(value)
        {
            this.rbc = rbc;
        }

        public override string GetStatus()
        {
            double RBCValue = rbc.GetValue();
            //double HCTValue = GetValue();
            if (Form1.patient.GetGender() == "Male")
            {
                return GetRes(RBCValue * 0.37, RBCValue * 0.54);
                //if (HCTValue < RBCValue * 0.37)
                //{
                //    return "Low";
                //}
                //else if (HCTValue > RBCValue * 0.54)
                //{
                //    return "High";
                //}
                //else
                //{
                //    return "Normal";
                //}
            }
            else
            {
                return GetRes(RBCValue * 0.33, RBCValue * 0.47);
                //if (HCTValue < RBCValue * 0.33)
                //{
                //    return "Low";
                //}
                //else if (HCTValue > RBCValue * 0.47)
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
}
