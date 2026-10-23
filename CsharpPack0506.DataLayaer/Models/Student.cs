using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPack0506.DataLayer.Models
{
    public class Student : User
    {
        public Student(string firstName, string lastName, string mobile, string nationalCode) : base(firstName, lastName, mobile, nationalCode)
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
        public Student(string firstname, string lastname, string mobile, string nationalcode, DateTime birthDate) : this(firstname, lastname, mobile, nationalcode)
        {
            if (birthDate == DateTime.MinValue)
                throw new Exception("Please enter your birthdate!!");

            BirthDate = birthDate;

        }
        public string Relation { get; set; }

        public string GetInfo()
        {
            return $"{FirstName + ' ' + LastName} is registered as a student";
        }
    }
}
