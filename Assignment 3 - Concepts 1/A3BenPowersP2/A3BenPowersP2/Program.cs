using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Assignment 3 Part 2
// Ben Powers
// Student Number 7986250

namespace A3BenPowersP2
{
    class Program
    {
        static void Main(string[] args)
        
        {
            string homeMenu;
            int numberOne;
            int numberTwo;
            string numString;
            

            Console.WriteLine("Ben Powers");
            Console.WriteLine("-------------------------------------------------------------------------");
            do

            {

                // Home menu for math calculator

                // add method
                Console.WriteLine("Press 1 for addition");

                // sub method
                Console.WriteLine("Press 2 for subtraction");

                // divide method
                Console.WriteLine("Press 3 for division");

                // multiply method
                Console.WriteLine("Press 4 for multiplication");

                Console.WriteLine("------------------------------------------------------------------------");

                homeMenu = Console.ReadLine();

                // adding two numbers
                if (homeMenu == "1")
                    try

                    {
                        Console.WriteLine("Please Enter The First Number: ");
                        numString = Console.ReadLine();
                        numberOne = int.Parse(numString);
                        Console.WriteLine("Please Enter The Second Number: ");
                        numString = Console.ReadLine();
                        numberTwo = int.Parse(numString);
                        Console.WriteLine("{0} + {1} = {2}", numberOne, numberTwo, numberOne + numberTwo);

                    }
                    catch
                    {
                        Console.WriteLine("invalid input please try again!");
                    }

                // subtracting two numbers
                if (homeMenu == "2")
                    try
                    {
                        Console.WriteLine("Please Enter The First Number: ");
                        numString = Console.ReadLine();
                        numberOne = int.Parse(numString);
                        Console.WriteLine("Please Enter The Second Number: ");
                        numString = Console.ReadLine();
                        numberTwo = int.Parse(numString);
                        Console.WriteLine("{0} - {1} = {2}", numberOne, numberTwo, numberOne - numberTwo);
                    }
                    catch
                    {
                        Console.WriteLine("ERROR, you must have typed a incorrect function!");
                    }

                // dividing two numbers
                if (homeMenu == "3")
                    try
                    {
                        Console.WriteLine("Please Enter The First Number: ");
                        numString = Console.ReadLine();
                        numberOne = int.Parse(numString);
                        Console.WriteLine("Please Enter The Second Number: ");
                        numString = Console.ReadLine();
                        numberTwo = int.Parse(numString);
                        Console.WriteLine("{0} / {1} = {2}", numberOne, numberTwo, numberOne / numberTwo);
                    }
                    catch
                    {
                        Console.WriteLine("WOOPS that didnt work please try again!");
                    }

                // multiplying two numbers
                if (homeMenu == "4")
                    try
                    {
                        Console.WriteLine("Please Enter The First Number: ");
                        numString = Console.ReadLine();
                        numberOne = int.Parse(numString);
                        Console.WriteLine("Please Enter The Second Number: ");
                        numString = Console.ReadLine();
                        numberTwo = int.Parse(numString);
                        Console.WriteLine("{0} * {1} = {2}", numberOne, numberTwo, numberOne * numberTwo);
                    }
                    catch
                    {
                        Console.WriteLine("Must be numbers not letters!");
                    }

            } while (true); 

           

        }

    }
}

