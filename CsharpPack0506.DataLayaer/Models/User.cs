using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPack0506.DataLayer.Models
{
    public abstract class User
    {
        public User(string firstName, string lastName, string mobile, string nationalCode)
        {
            //if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(nationalCode))
            //{
            //    throw new Exception("Please enter your information correctly!");
            //}

            FirstName = firstName;
            LastName = lastName;
            Mobile = mobile;
            NationalCode = nationalCode;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string NationalCode { get; set; }
        public string CardNumber { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
