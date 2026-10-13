using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject0506.Models
{
    internal class Coach : User
    {
        public Coach(string firstName, string lastName, string nationalCode, string mobile) : base(firstName, lastName, nationalCode, mobile)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(nationalCode) || string.IsNullOrEmpty(mobile))
            {
                throw new Exception("Please enter your data");
            }
            FirstName = firstName;
            LastName = lastName;
            NationalCode = nationalCode;
            Mobile = mobile;
        }

        public Coach(string firstname, string lastname, string mobile, string nationalcode, int experienceYears) : this(firstname, lastname, mobile, nationalcode)
        {
            ExperienceYears = experienceYears;
        }
        public int ExperienceYears { get; set; }

        public override string ShowFullName()
        {
            return $"{FirstName} {LastName} with {ExperienceYears} experience years is registered as a master";
        }
    }
}
