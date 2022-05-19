using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class Urea : BloodTestX
    {
        private bool questionIsEastern;
        public Urea(double value) : base(value)
        {
            questionIsEastern = false;
        }

        public override string GetStatus()
        {
            //double value = GetValue();
            if (questionIsEastern == false)
            {
                return GetRes(17, 43);
                //if (value < 17)
                //{
                //    return "Low";
                //}
                //else if (value > 43)
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
                return GetRes(17, 43 * 1.1);
                //if (value < 17)
                //{
                //    return "Low";
                //}
                //else if (value > 43*1.1)
                //{
                //    return "High";
                //}
                //else
                //{
                //    return "Normal";
                //}

            }

            //Here we have to add question!

        }
    }
}
