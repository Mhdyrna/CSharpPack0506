using MyProject0506.Models;

namespace MyProject0506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User FirstUser = new User(firstName: "reza", lastName: "ramezani", nationalCode: "0044223", mobile: "09124457898");
            Console.WriteLine(FirstUser.ShowFullName());

            DateTime birthDate = DateTime.Now.AddYears(-30);
            Athlete FirstAthlete = new Athlete("karim", "mirzaee", "44556677", "09121527852", birthDate);
            FirstAthlete.Weight = 80;
            Console.WriteLine(FirstAthlete.ShowFullName());
        }
    }
}
