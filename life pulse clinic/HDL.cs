using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class HDL : BloodTestX
    {
        public HDL(double value) : base(value)
        {
        }


        public override string GetStatus()
        {
            bool questionIsEthiopain = Form1.questions.GetEthiopian();
            if (questionIsEthiopain==false)
            {
                if (Form1.patient.GetGender()=="Male")
                {
                    return GetRes(29, 62);
                }
                else
                {
                    return GetRes(34, 82);
                }
            }
            else
            {
                if (Form1.patient.GetGender() == "Male")
                {
                    return GetRes(29*1.2, 62*1.2);
                }
                else
                {
                    return GetRes(34*1.2, 82*1.2);
                }
            }
        }
        public override ArrayList GetDisease()
        {
            diseases = new ArrayList();
            if (GetStatus()=="Low")
            {
                diseases.Add("מחלות לב");
                diseases.Add("היפרליפידמיה )שומנים בדם(");
                if (Form1.patient.GetAge()>=18)
                {
                    diseases.Add("סוכרת מבוגרים");
                }
                return diseases;
            }
            else
            {
                return null;
            }
        }
    }
}
