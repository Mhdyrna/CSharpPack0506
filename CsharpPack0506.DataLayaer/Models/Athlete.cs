using CSharpPack0506.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPack0506.DataLayer.Models
{
    public class Athlete : User
    {
        public Athlete() : base("", "", "", "")
        {

        }

        //constructor
        public Athlete(string name, string lastName, string mobile, string nationalCode) : base(name, lastName, mobile, nationalCode)
        {

        }
        public Athlete(string name, string lastName, string mobile, string nationalCode, DateTime birthDate) : this(name, lastName, mobile, nationalCode)
        {
            if (birthDate == DateTime.MinValue)
                throw new Exception("لطفا تاریخ تولد را به صورت کامل و صحیح وارد نمایید.");

            BirthDate = birthDate;
        }

      

        public string GetInfo()
        {
            return $"{FirstName + ' ' + LastName} is registered as an athlete";
        }
    }
}
