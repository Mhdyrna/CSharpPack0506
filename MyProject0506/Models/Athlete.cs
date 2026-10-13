using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject0506.Models
{
    internal class Athlete : User
    {
        public Athlete(string firstName,string lastName,string nationalCode, string mobile):base(firstName, lastName, nationalCode, mobile)
        {
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || 
                string.IsNullOrEmpty(nationalCode) || string.IsNullOrEmpty(mobile))
            {
                throw new Exception("Please enter your data");
            }
            FirstName = firstName;
            LastName = lastName;
            NationalCode = nationalCode;
            Mobile = mobile;
        }

       public Athlete(string firstName, string lastName, string nationalCode, string mobile,DateTime birthDate,decimal weight) : this(firstName,lastName,nationalCode,mobile)
        {
            if(birthDate==DateTime.MinValue)
            {
                throw new Exception("Please enter your birthdate!");
            }
            BirthDate = birthDate;
            Weight = weight;
        }
        public decimal Weight { get; set; }

        public override string ShowFullName()
        {
            return FirstName + " " + LastName + " " + Weight+ "kg " + "is registered as an athlete.";
        }
    }
}
