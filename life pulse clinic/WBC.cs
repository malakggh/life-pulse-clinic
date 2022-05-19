﻿using System;
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
            //double value = GetValue();
            if (age >= 0 && age <= 3)
            {
                //if (value < 6000)
                //{
                //    return "Low";
                //}else if (value > 17500)
                //{
                //    return "High";
                //}
                //else
                //{
                //    return "Normal";
                //}
                return GetRes(6000, 17500);
            }else if(age >= 4 && age <= 17)
            {
                //if (value < 5500)
                //{
                //    return "Low";
                //}
                //else if (value > 15500)
                //{
                //    return "High";
                //}
                //else
                //{
                //    return "Normal";
                //}
                return GetRes(5500, 15500);
            }
            else if(age >= 18)
            {
                //if (value < 4500)
                //{
                //    return "Low";
                //}
                //else if (value > 11000)
                //{
                //    return "High";
                //}
                //else
                //{
                //    return "Normal";
                //}
                return GetRes(4500, 11000);
            }
            throw new Exception("Age Out of Range");
        }
    }
}
