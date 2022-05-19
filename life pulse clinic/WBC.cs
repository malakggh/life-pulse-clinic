using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class WBC : BloodTestX
    {
        private Patient patient;

        public WBC(double value,Patient patient) : base(value)
        {
            this.patient = patient;
        }

        public override string GetStatus()
        {
            int age = patient.GetAge();
            double value = GetValue();
            if (age >= 0 && age <= 3)
            {
                if (value < 6000)
                {
                    return "Low";
                }else if (value > 17500)
                {
                    return "High";
                }
                else
                {
                    return "Normal";
                }
            }else if(age >= 4 && age <= 17)
            {
                if (value < 5500)
                {
                    return "Low";
                }
                else if (value > 15500)
                {
                    return "High";
                }
                else
                {
                    return "Normal";
                }

            }
            else if(age >= 18)
            {
                if (value < 4500)
                {
                    return "Low";
                }
                else if (value > 11000)
                {
                    return "High";
                }
                else
                {
                    return "Normal";
                }
            }
            throw new Exception("Age Out of Range");
        }
    }
}
