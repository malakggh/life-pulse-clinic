using System.Collections;

namespace life_pulse_clinic
{
    public class BloodTest
    {
        private BloodTestX[] arr;

        public BloodTest(double WBC, double Neut, double Lymph, double RBC, double HCT, double Urea, double Hb, double Crtn, double Iron, double HDL, double Ap)
        {
            this.arr = new BloodTestX[11];
            arr[0] = new WBC(WBC);
            arr[1] = new Neut(Neut, (WBC)arr[0]);
            arr[2] = new Lymph(Lymph, (WBC)arr[0]);
            arr[3] = new RBC(RBC);
            arr[4] = new HCT(HCT, (RBC)arr[3]);
            arr[5] = new Urea(Urea);
            arr[6] = new Hb(Hb);
            arr[7] = new Crtn(Crtn);
            arr[8] = new Iron(Iron);
            arr[9] = new HDL(HDL);
            arr[10] = new Ap(Ap);
        }
        public ArrayList GetDisease()
        {
            ArrayList result = new ArrayList();
            for (int i = 0; i < arr.Length; i++)
            {
                ArrayList helpArr = arr[i].GetDisease();
                if (helpArr != null)
                {
                    foreach (string item in helpArr)
                    {
                        if (!(result.Contains(item)))
                        {
                            result.Add(item);
                        }
                    }
                }
            }
            return result;
        }
        public string[] GetNameValue()
        {
            string[] result = new string[22];
            for (int i = 0;i < arr.Length; i++)
            {
                result[i]=arr[i].GetType().Name;
                result[i + 11] = arr[i].GetValue().ToString();
            }
            return result;
        }

        public void GetStatus()
        {
            string message = "";
            foreach (BloodTestX item in arr)
            {
                message += item.GetType().Name + " - " + item.GetStatus();
            }
            MessageBox.Show(message);
        }
    }
}

