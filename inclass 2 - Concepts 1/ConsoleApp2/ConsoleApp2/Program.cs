using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name program title
            Console.Title = "Console String Manipulation";

            //Begin menu code
            int i = 0;
            int menuChoice = 0;
            while (menuChoice != 4)
            {
                Console.WriteLine("Please choose one of the follow options: ");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("1. Calculate the factorial of an integer between 0 and 15");
                Console.WriteLine("2. Reverse a given string");
                Console.WriteLine("3. Find a sub-string in a given string");
                Console.WriteLine("4. Exit");
                Console.WriteLine("----------------------------------------------------------------------");

                //Validate that user entered a number
                try
                {
                    menuChoice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a number");
                }

                switch (menuChoice)
                {
                    case 1:
                        factorial(i);
                        break;
                    case 2:
                        reverse();
                        break;
                    case 3:
                        substring();
                        break;
                    case 4:
                        Console.WriteLine("Exiting Application");
                        return;
                }

                Console.ReadLine();
            }
        }

        static void factorial(double a)
        {
            //Activate boolean for good/bad messages
            bool goodMessage = false;

            //Jacob Martin helped me with this section
            //Calculate factorial of inputted number
            Console.WriteLine("Please select a number between 0 and 15.");
            string number = Console.ReadLine();

            //If field is inputted correctly, output factorial
            if (number == "0")
            {
                a = 1;
                goodMessage = true;
            }
            else if (number == "1")
            {
                a = 1;
                goodMessage = true;
            }
            else if (number == "2")
            {
                a = 2;
                goodMessage = true;
            }
            else if (number == "3")
            {
                a = 6;
                goodMessage = true;
            }
            else if (number == "4")
            {
                a = 24;
                goodMessage = true;
            }
            else if (number == "5")
            {
                a = 120;
                goodMessage = true;
            }
            else if (number == "6")
            {
                a = 720;
                goodMessage = true;
            }
            else if (number == "7")
            {
                a = 5040;
                goodMessage = true;
            }
            else if (number == "8")
            {
                a = 40320;
                goodMessage = true;
            }
            else if (number == "9")
            {
                a = 362880;
                goodMessage = true;
            }
            else if (number == "10")
            {
                a = 3628800;
                goodMessage = true;
            }
            else if (number == "11")
            {
                a = 39916800;
                goodMessage = true;
            }
            else if (number == "12")
            {
                a = 479001600;
                goodMessage = true;
            }
            else if (number == "13")
            {
                a = 6227020800;
                goodMessage = true;
            }
            else if (number == "14")
            {
                a = 87178291200;
                goodMessage = true;
            }
            else if (number == "15")
            {
                a = 1307674368000;
                goodMessage = true;
            }


            //If field is empty, cause error
            else if (number == "")
            {
                goodMessage = false;
            }

            if (goodMessage == false)
            {
                Console.WriteLine("ERROR: No number entered");
            }

            if (goodMessage == true)
            {
                Console.WriteLine("You chose " + number + " as your number");
                Console.WriteLine("The factorial of " + number + " is " + a);
                Console.WriteLine("Press enter to return to menu");
                Console.ReadLine();
            }
        }

        static void reverse()
        {
            Console.WriteLine("Please enter a word to be reversed");
            Console.WriteLine("-------------------------");
            string text = Console.ReadLine();
            if (text == "")
            {
                Console.WriteLine("ERROR: Please enter a proper word");
                Console.WriteLine();
                reverse();
            }
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine("Your word reversed is: ");
            Console.WriteLine(array);
            Console.WriteLine();
            Console.WriteLine("Please press enter to return to menu");
            Console.ReadLine();
        }

        static void substring()
        {
            Console.WriteLine("Please enter your original word");
            Console.WriteLine("-------------------------------");
            string firstString = Console.ReadLine();
            if (firstString == "")
            {
                Console.WriteLine("ERROR: Please enter a word");
                Console.WriteLine();
                substring();
            }

            Console.WriteLine("Please enter letters inside your original word to find their position");
            Console.WriteLine("-------------------------------");
            string secondString = Console.ReadLine();
            if (secondString == "")
            {
                Console.WriteLine("ERROR: Please enter a word");
                Console.WriteLine();
                substring();
            }
            else
            {
                string original = firstString;
                int position = original.IndexOf(secondString);
                if (position != -1)
                {
                    Console.WriteLine("Sub-string position: " + position.ToString());
                    Console.WriteLine();
                    Console.WriteLine("Please press enter to return to menu");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Sub-string was not found, please try again");
                    Console.WriteLine();
                    substring();
                }
                Console.ReadLine();
            }
        }
    }
}
