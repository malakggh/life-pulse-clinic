using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life_pulse_clinic
{
    public class Patient
    {
        private string firstName;
        private string lastName;
        private string id;
        private int age;
        private string gender;
        private string city;
        private string phone;
        private string email;
        
        public Patient(string firstName,string lastName,string id,int age,string gender, string city,string phone,string email)
        {
            this.firstName = firstName;         
            this.lastName = lastName;
            this.id = id;
            this.age = age;
            this.gender = gender;
            this.city = city;
            this.phone = phone;
            this.email = email;
        }
        public int GetAge() { return age; }
    }
}
