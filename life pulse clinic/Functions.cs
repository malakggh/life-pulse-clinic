using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class Functions
    {
        public static int GetUsernameIndex(string username)
        {
            Excel excel = new Excel(Form1.projectPath + Form1.accountsPath, 1);
            try
            {
                int index = 0;
                while (true)
                {
                    string str = excel.ReadCell(index, 0);
                    if (str == username)
                    {
                        return index;
                    }
                    else if (str == "")
                    {
                        return -1;
                    }
                    index++;
                }

            }
            catch (Exception)
            {
                throw new Exception("Error Occured While Checking If User Exist");
            }
            finally
            {
                excel.closeXl();
            }
        }
        public static bool IsIdExist(string id)
        {
            Excel excel = new Excel(Form1.projectPath + Form1.accountsPath, 1);
            try
            {
                int index = 0;
                while (true)
                {
                    string str = excel.ReadCell(index, 2);
                    if (str == id)
                    {
                        return true;
                    }
                    else if (str == "")
                    {
                        return false;
                    }
                    index++;
                }

            }
            catch (Exception)
            {
                throw new Exception("Error Occured While Checking If Id Exist");
            }
            finally
            {
                excel.closeXl();
            }
        }
        public static bool IsPasswordMatch(int userIndex, string password)
        {
            Excel excel = new Excel(Form1.projectPath + Form1.accountsPath, 1);
            try
            {
                if (excel.ReadCell(userIndex, 1) == password)
                {
                    return true;
                }
                return false;

            }
            catch (Exception)
            {

                throw new Exception("Error Occured While Checking If Password Match");
            }
            finally
            {
                excel.closeXl();
            }
        }
        public static bool IsUsernameLegal(string username)
        {
            if (username.Length < 6)
                return false;
            if (username.Length > 8)
                return false;
            int integerCounter = 0;
            for (int i = 0; i < username.Length; i++)
            {
                if (username[i] >= '0' && username[i] <= '9')
                {
                    integerCounter++;
                }
            }
            if (integerCounter > 2)
                return false;
            return true;
        }
        public static bool IsPasswordLegal(string password)
        {
            if (password.Length < 8)
                return false;
            if (password.Length > 10)
                return false;
            bool containsInteger = false;
            bool containsLetter = false;
            bool containsSpeacial = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    containsInteger = true;
                }
                else if ((password[i] >= 'a' && password[i] <= 'z') || (password[i] >= 'A' && password[i] <= 'Z'))
                {
                    containsLetter = true;
                }
                else
                {
                    containsSpeacial = true;
                }
            }
            return containsInteger && containsLetter && containsSpeacial;
        }
        public static bool IsIdLegal(string id)
        {
            if (id.Length != 9)
            {
                return false;
            }
            for (int i = 0; i < id.Length; i++)
            {
                if (!(id[i] >= '0' && id[i] <= '9'))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsEmailLegal(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
        public static bool IsAgeLegal(int age)
        {
            if (age > 0 && age < 120)
            {
                return true;
            }
            return false;
        }
        public static bool IsPhoneNumberLegal(string phoneNumber)
        {
            string pattern = @"^\+?(972|0)(\-)?0?(([23489]{1}\d{7})|[5]{1}\d{8})$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(phoneNumber);
        }
    }
}
