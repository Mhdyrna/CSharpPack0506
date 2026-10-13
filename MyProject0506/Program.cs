using MyProject0506.Models;
using System.Collections.Generic;

namespace MyProject0506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User firstUser = new User(firstName: "reza", lastName: "ramezani", nationalCode: "0044223", mobile: "09124457898");
            Console.WriteLine(firstUser.ShowFullName());

            DateTime birthDate = DateTime.Now.AddYears(-30);
            Athlete firstAthlete = new Athlete("karim", "mirzaee", "044556677", "09121527852");
            firstAthlete.Weight = 80;
            Console.WriteLine(firstAthlete.ShowFullName());
            try
            {
                Coach firstCoach = new Coach("mohsen", "nazari", "0256578", "09123214587", 5);
                Console.WriteLine(firstCoach.ShowFullName());
            }

            catch (Exception ex) 
            {
                throw;
            }
            List<User> users = new List<User>();
            users.Add(new Athlete("Ahmad", "mirzaee", "032556677", "09121527852",birthDate,81));
            users.Add(new Coach("kazem", "nazari", "023456578", "09129014587", 5));
            foreach(User user in users)
            {
                Console.WriteLine(user.ShowFullName());
            }
        }
    }
}
