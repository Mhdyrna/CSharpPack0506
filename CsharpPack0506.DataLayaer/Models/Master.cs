using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPack0506.DataLayer.Models
{
    public class Master: User
    {
        public Master(string firstName, string lastName, string mobile, string nationalCode) : base(firstName, lastName, mobile, nationalCode)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(nationalCode))
            {
                throw new Exception("Please enter your information correctly!");
            }

            FirstName = firstName;
            LastName = lastName;
            Mobile = mobile;
            NationalCode = nationalCode;
        }
        public string Card { get; set; }
    }
}
