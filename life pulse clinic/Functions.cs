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
        public static string GetRecommendation(string disease)
        {
            if (disease == "אנמיה")
            {
                return "שני כדורי 10 מג של B12 ביום למשך חודש";
            }
            else if (disease == "דיאטה")
            {
                return "לתאם פגישה עם תזונאי";
            }
            else if (disease == "דימום")
            {
                return "להתפנות בדחיפות לבית החולים";
            }
            else if (disease == "היפרליפידמיה )שומנים בדם(")
            {
                return "לתאם פגישה עם תזונאי, כדור 5 מג של סימוביל ביום למשך שבוע";
            }
            else if (disease == "הפרעה ביצירת הדם / תאי דם")
            {
                string n1 = "כדור 10 מג של B12 ביום למשך חודש";
                string n2 = "כדור 5 מג של חומצה פולית ביום למשך חודש";
                return n1 + "\n" + n2;
            }
            else if (disease == "הפרעה המטולוגית")
            {
                return "זריקה של הורמון לעידוד ייצור תאי הדם האדומים";
            }
            else if (disease == "הרעלת ברזל")
            {
                return " להתפנות לבית החולים";
            }
            else if (disease == "התייבשות")
            {
                return "מנוחה מוחלטת בשכיבה, החזרת נוזלים בשתייה";
            }
            else if (disease == "זיהום")
            {
                return "אנטיביוטיקה ייעודית";
            }
            else if (disease == "חוסר בוויטמינים")
            {
                return " הפנייה לבדיקת דם לזיהוי הוויטמינים החסרים";
            }
            else if (disease == "מחלה ויראלית")
            {
                return "לנוח בבית";
            }
            else if (disease == "מחלות בדרכי המרה")
            {
                return " הפנייה לטיפול כירורגי";
            }
            else if (disease == "מחלות לב")
            {
                return "לתאם פגישה עם תזונאי";
            }
            else if (disease == "מחלת דם")
            {
                return "שילוב של ציקלופוספאמיד וקורטיקוסרואידים";
            }
            else if (disease == "מחלת כבד")
            {
                return "הפנייה לאבחנה ספציפית לצורך קביעת טיפול";
            }
            else if (disease == "מחלת כליה")
            {
                return "איזון את רמות הסוכר בדם";
            }
            else if (disease == "מחסור בברזל")
            {
                return "שני כדורי 10 מג של B12 ביום למשך חודש";
            }
            else if (disease == "מחלות שריר")
            {
                return "שני כדורי 5 מג של כורכום c3 של אלטמן ביום למשך חודש";
            }else if(disease == "מעשנים")
            {
                return "להפסיק לעשן";
            }else if(disease == "מחלת ריאות")
            {
                return "להפסיק לעשן / הפנייה לצילום רנטגן של הריאות";
            }else if(disease == "פעילות יתר של בלוטת התריס")
            {
                return " Propylthiouracil להקטנת פעילות בלוטת התריס";
            }else if(disease == "סוכרת מבוגרים")
            {
                return "התאמת אינסולין למטופל";
            }else if(disease == "סרטן")
            {
                return " אנטרקטיניב - Entrectinib";
            }else if(disease == "צריכה מוגברת של בשר")
            {
                return "לתאם פגישה עם תזונאי";
            }else if(disease == "שימוש בתרופות שונות")
            {
                return "הפנייה לרופא המשפחה לצורך בדיקת התאמה בין התרופות";
            }else if(disease == "תת תזונה")
            {
                return "לתאם פגישה עם תזונאי";
            }
            else
            {
                return "";
            }
        }
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
