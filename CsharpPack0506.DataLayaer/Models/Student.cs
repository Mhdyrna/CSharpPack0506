using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPack0506.DataLayer.Models
{
    public class Student : User
    {
        public Student() : base("", "", "", "")
        {

        }

        //constructor
        public Student(string name, string lastName, string mobile, string nationalCode) : base(name, lastName, mobile, nationalCode)
        {

        }
        public Student(string name, string lastName, string mobile, string nationalCode, DateTime birthDate) : this(name, lastName, mobile, nationalCode)
        {
            if (birthDate == DateTime.MinValue)
                throw new Exception("لطفا تاریخ تولد را به صورت کامل و صحیح وارد نمایید.");

            BirthDate = birthDate;
        }
 
        public string Relation { get; set; }

        public string GetInfo()
        {
            return $"{FirstName + ' ' + LastName} is registered as a student";
        }
    }
}
