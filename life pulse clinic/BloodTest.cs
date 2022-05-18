using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class BloodTest
    {
        private double WBC;
        private double Neut;
        private double Lymph;
        private double RBC;
        private double HCT;
        private double Urea;
        private double Hb;
        private double Crtn;
        private double Iron;
        private double HDL;
        private double AP;
        public BloodTest(double WBC,double Neut,double Lymph,double RBC,double HCT,double Urea, double Hb, double Crten, double Iron, double HDL, double AP)
        {
            this.WBC = WBC;
            this.Neut = Neut;
            this.Lymph = Lymph;
            this.RBC = RBC;
            this.HCT = HCT;
            this.Urea = Urea;
            this.Hb = Hb;
            this.Crtn = Crten;
            this.Iron = Iron;
            this.HDL = HDL;
            this.AP = AP;

        }
    }
}
