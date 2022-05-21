using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class BloodTest
    {
        private BloodTestX[] arr;

        public BloodTest(double WBC,double Neut,double Lymph,double RBC,double HCT,double Urea, double Hb, double Crtn, double Iron, double HDL, double Ap)
        {
            this.arr = new BloodTestX[11];
            arr[0] = new WBC(WBC);
            arr[1] = new Neut(Neut,(WBC)arr[0]);
            this.lymph = new Lymph(Lymph,this.wbc);
            this.rbc = new RBC(RBC);
            this.hct = new HCT(HCT,this.rbc);
            this.urea = new Urea(Urea);
            this.hb = new Hb(Hb);
            this.crtn = new Crtn(Crtn);
            this.iron = new Iron(Iron);
            this.hdl = new HDL(HDL);
            this.ap = new Ap(Ap);
        }

        public WBC GetWBC() { return this.wbc; }

        public ArrayList GetDisease()
        {
            ArrayList arr = wbc.GetDisease();
            ArrayList arr2 = neut.GetDisease();
        }
    }
}

