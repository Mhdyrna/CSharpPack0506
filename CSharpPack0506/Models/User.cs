using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPack0506.Models
{
    internal class User
    {
        public User(string firstname, string lastname, string mobile, string nationalcode)
        {
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(nationalcode))
            {
                throw new Exception("Please enter your information correctly!");
            }

            FirstName = firstname;
            LastName = lastname;
            Mobile = mobile;
            NationalCode = nationalcode;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string NationalCode { get; set; }
        public string CardNumber { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
