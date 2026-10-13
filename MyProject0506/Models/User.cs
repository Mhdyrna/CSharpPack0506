using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject0506.Models
{
    internal class User
    {

        public User(string firstName,string lastName,string nationalCode,string mobile)
        {
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || 
               string.IsNullOrEmpty(nationalCode) || string.IsNullOrEmpty(mobile))
            {
                throw new Exception("Please enter your data!");
            }
            FirstName = firstName;
            LastName = lastName;
            NationalCode = nationalCode;
            Mobile = mobile;
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }

        public string Mobile { get; set; }

        public DateTime BirthDate { get; set; }

        public virtual string ShowFullName()
        {
            return FirstName + " " + LastName + "is registered as an user.";
        }


    }
}
