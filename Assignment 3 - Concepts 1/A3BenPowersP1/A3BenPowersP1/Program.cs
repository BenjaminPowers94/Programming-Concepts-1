using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Assignment 3 Part 1
// Ben Powers
// Student Number 7986250

namespace A3BenPowersP1
{
    class Program
    {
        public static object Int { get; private set; }

        static void Main(string[] args)
        {

            string menuSelectedByUser;
            string exitString = "no";
            
            
            Console.WriteLine("Ben Powers");
            Console.WriteLine("----------------------------------------------------------------------------");
            do
            {
                

                // even numbers
                Console.WriteLine("1. for a list of even numbers");

                // perfect squares
                Console.WriteLine("2. for perfect squares");

                // exits program
                Console.WriteLine("3. to close the program");

                //asks user to select a number
                Console.WriteLine("Select a number:");

                // even numbers (first option)
                menuSelectedByUser = Console.ReadLine();
                if (menuSelectedByUser == "1")
                {
                    Console.WriteLine("Type a number for a list of even numbers: ");
                    string input = Console.ReadLine();
                    int x;
                    if (!int.TryParse(input, out x))
                    {
                        Console.WriteLine("You didn't enter number");
                    }

                    for(int i = 0; i < x*2; i+=2)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }

                // perfect squares (option 2)
                else if (menuSelectedByUser == "2")
                {
                    double next = 1;
                    Console.WriteLine("The square of 1 is 1");
                    Console.WriteLine("Do you wish to continue?[Y/N]");
                    string a = Console.ReadLine();

                    if (a == "Y")
                    {
                        while (a == "Y")
                        {
                            next++;
                            do
                            {

                                double result = next * next;
                                Console.WriteLine("The square of " + next + " is " + result);
                                next++;
                                Console.WriteLine("Do you wish to continue?[Y/N]");
                                a = Console.ReadLine();

                            }
                            while (a == "Y");
                            Console.WriteLine("exit");

                        }
                    }
             
                } 
                
                // exit program (option 3)
                else if (menuSelectedByUser == "3")
                {
                    Console.WriteLine("Do you want to exit the program? [yes/no]");
                    exitString = Console.ReadLine();
                    
                }

            }   while (exitString != "yes");
            
        }
        
        
    }
}
