using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment 2 Part 1 
// By Ben Powers
// Student number 7986250 

namespace A2BenjaminPowersP1
{
    class Program
    {
        static void Main(string[] args)
        {
            string student;
            int age, months;

            int internationalFee = 0;
            int baseTuitionFee = 0;
            int registrationFee = 0;

            double hst = 0;
            double tuitionTotal = 0;
            
            Console.WriteLine("Ben Powers");
            Console.WriteLine("------------------------------------------");


            // International Fee
            Console.WriteLine("Are you a Canadian or International student");
            Console.WriteLine("Enter I for International");
            student = Console.ReadLine();

            if (student == "I")
            {
                internationalFee = 100;
            }

            // Basic Tuition Fee
            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());

            if (age <= 18)
            {
                baseTuitionFee = 300;
            }
            if (age > 18 && age <= 49)
            {
                baseTuitionFee = 500;
            }
            else // age >= 50
            {
                baseTuitionFee = 400;
            }

            // Registration Fee
            Console.WriteLine("What months did you register?");
            Console.WriteLine("1.the Fall months (Sept., Oct., Nov., or Dec.)");
            Console.WriteLine("2.the Winter months (Jan., Feb., Mar. or Apr.)");
            Console.WriteLine("3.the Summer months (May, Jun., Jul. or Aug.)");

            do
            {
                months = int.Parse(Console.ReadLine());

                switch (months)
                {
                    case 1:
                        registrationFee = 250;

                        break;
                    case 2:
                        registrationFee = 220;
                        break;
                    case 3:
                        registrationFee = 150;
                        break;
                    default:
                        registrationFee = 0;
                        break;
                }
            } while (registrationFee == 0);

            // Caculate Total Tuition Fee
            hst = (internationalFee + baseTuitionFee + registrationFee) * 0.13;  // 13% HST
            tuitionTotal = internationalFee + baseTuitionFee + registrationFee + hst;


            Console.WriteLine("Base Tuition : $" + baseTuitionFee);
            Console.WriteLine("International Tuition Fee : $" + internationalFee);
            Console.WriteLine("Registration Fee's : $" + registrationFee);
            Console.WriteLine("HST Taxes : $" + hst);
            Console.WriteLine("Final Price for student : $" + tuitionTotal);
        }
    }
}
