using System.Text.RegularExpressions;

namespace CSharpPack0506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string FirstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string LastName = Console.ReadLine();

            Console.Write("Enter Your Birth Date ('dd/mm/yyyy') ");
            string BirthDate = Console.ReadLine();

            DateTime birthDate = DateTime.Parse(BirthDate);
            int Age = DateTime.Now.Year - birthDate.Year;

            Console.Write("Enter your mobile number: ");
            string Mobile = Console.ReadLine();

            if (Mobile.StartsWith("+98"))
            {
                Mobile = "0" + Mobile.Substring(3);

            }
            bool IsValid = Mobile.Length == 11 && Mobile.StartsWith("0");


            Console.WriteLine("Enter your national code: ");
            string NationalCode = Console.ReadLine();

            bool IsNationalCodeValid = Regex.IsMatch(NationalCode, @"^\d{10}$");

            Console.Write("Enter your card number: ");
            string Card = Console.ReadLine();
            string BankName = "Unknown";
            if (Card.Length == 16)
            {
                string Prefix = Card.Substring(0, 6);

                switch (Prefix)
                {
                    case "603799":
                        BankName = "Bank Melli";
                        break;

                    case "589210":
                    case "627381": // Ansar - merged into Sepah
                    case "639599": // Ghavamin - merged into Sepah
                    case "636949": // Hekmat Iranian - merged into Sepah
                    case "639370": // Mehr Eghtesad - merged into Sepah
                    case "606737": // Mehr Eghtesad - merged into Sepah
                        BankName = "Bank Sepah";
                        break;

                    case "627648":
                    case "207177":
                        BankName = "Bank Tose'e Saderat Iran";
                        break;

                    case "627961":
                        BankName = "Bank Sanat o Madan";
                        break;

                    case "603770":
                    case "639217":
                        BankName = "Bank Keshavarzi";
                        break;

                    case "628023":
                        BankName = "Bank Maskan";
                        break;

                    case "627760":
                        BankName = "Post Bank Iran";
                        break;

                    case "502908":
                        BankName = "Bank Tose'e Taavon";
                        break;

                    case "627412":
                        BankName = "Bank Eghtesad Novin";
                        break;

                    case "589463":
                        BankName = "Bank Refah Kargaran";
                        break;

                    case "603769":
                        BankName = "Bank Saderat Iran";
                        break;

                    case "585983":
                    case "627353":
                        BankName = "Bank Tejarat";
                        break;

                    case "610433":
                    case "991975":
                        BankName = "Bank Mellat";
                        break;

                    case "639347":
                    case "502229":
                        BankName = "Bank Pasargad";
                        break;

                    case "622106":
                    case "627884":
                    case "639194":
                        BankName = "Bank Parsian";
                        break;

                    case "621986":
                        BankName = "Bank Saman";
                        break;

                    case "639607":
                        BankName = "Bank Sarmayeh";
                        break;

                    case "502806":
                    case "504706":
                        BankName = "Bank Shahr";
                        break;

                    case "639346":
                        BankName = "Bank Sina";
                        break;

                    case "502938":
                        BankName = "Bank Dey";
                        break;

                    case "505785":
                        BankName = "Bank Iran Zamin";
                        break;

                    case "505416":
                        BankName = "Bank Gardeshgari";
                        break;

                    case "627488":
                    case "502910":
                        BankName = "Bank Karafarin";
                        break;

                    case "504172":
                        BankName = "Bank Resalat";
                        break;

                    case "505809":
                    case "585947":
                        BankName = "Bank Khavarmianeh";
                        break;

                    case "636214":
                        BankName = "Bank Ayandeh";
                        break;

                    case "636795":
                        BankName = "Bank Markazi";
                        break;

                    case "606256":
                        BankName = "Bank Melal";
                        break;

                    default:
                        BankName = "Unknown";
                        break;
                }
                Console.WriteLine($"Bank: {BankName}");
            }

            else
            {
                Console.WriteLine("Your card is invalid!");
            }
            Console.WriteLine("\n========== User Information ==========");

            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Birth Date: {BirthDate}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Mobile: {Mobile}");
            Console.WriteLine($"National Code: {NationalCode}");
            Console.WriteLine($"Card Number: {Card}");
            Console.WriteLine($"Bank: {BankName}");

            Console.WriteLine("======================================");
        }

    }

}
