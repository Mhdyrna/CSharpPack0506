using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPack0506.Models
{
    internal class Student : User
    {
        public Student(string firstname, string lastname, string mobile, string nationalcode) : base(firstname, lastname, mobile, nationalcode)
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
        public Student(string firstname, string lastname, string mobile, string nationalcode, DateTime birthDate) : this(firstname, lastname, mobile, nationalcode)
        {
            if (birthDate == DateTime.MinValue)
                throw new Exception("Please enter your birthdate!!");

            BirthDate = birthDate;

        }

        public string GetInfo()
        {
            return $"{FirstName + ' ' + LastName} is registered as a student";
        }
    }
}
