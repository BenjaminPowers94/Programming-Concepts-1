using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// InClass 5 
// Ben Powers
// Student Number 7986250

namespace inClass5
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuSelectedByUser;
            string exitString = "no";
            string firstName;
            string lastName;
            int i;


            Console.WriteLine("Ben Powers");
            Console.WriteLine("----------------------------------------------------------");

            do
            {   
                // reversing first and last name
                Console.WriteLine("1. for Name Switching");
                // Valadating SIN number
                Console.WriteLine("2. for Check Digit Validation");
                // exit program option
                Console.WriteLine("3. to exit program");

                menuSelectedByUser = Console.ReadLine();

                // Name Switcher 
                if (menuSelectedByUser == "1")
                {
                    Console.WriteLine("Please enter your first name");
                    firstName = Console.ReadLine();
                    Console.WriteLine("Please enter your last name");
                    lastName = Console.ReadLine();
                    Console.WriteLine("{0}, {1}", lastName, firstName);
                    Console.WriteLine("Press Enter to return to menu");
                    Console.ReadLine();
                }
                
                // SIN checker
                if (menuSelectedByUser == "2")
                {
                    
                    Console.WriteLine();
              

                    
                    int[] multiply = new int[9];

                    multiply[0] = 1;
                    multiply[1] = 2;
                    multiply[2] = 1;
                    multiply[3] = 2;
                    multiply[4] = 1;
                    multiply[5] = 2;
                    multiply[6] = 1;
                    multiply[7] = 2;
                    multiply[8] = 1;
                    

                    // get SIN from user
                    Console.WriteLine("enter your SIN number");
                    string sin = Console.ReadLine();

                    // get 9 numbers from SIN inputed by user
                    int[] numbers = new int[9];
                    int a = 0;

                    for (i = 0; i < sin.Length; i++)
                    {
                        if (sin[i] != ' ')
                        {
                            numbers[a] = sin[i] - '0';                   
                            a++;
                        }
                    }


                    // get total
                    int temp, firstDigit, secondDigit, total = 0;
                    string s;

                    for (i = 0; i < 9; i++)
                    {
                        temp = numbers[i] * multiply[i];

                        if (temp < 10)
                        {
                            total += temp;
                        }
                        else                   
                        {
                            s = temp.ToString();                    

                            firstDigit = s[0] - '0';               
                            secondDigit = s[1] - '0';               

                            total += firstDigit + secondDigit;
                        }
                    }
                    

                    // calculate and display result 
                    Console.Write("total is " + total + ", so ");

                    if (total % 10 == 0)
                    {
                        Console.Write(sin + " is a valid SIN\n");
                    }
                    else                 
                    {
                        Console.Write(sin + " is not a valid SIN\n");
                    }
                    

                    
                    Console.WriteLine("Press Enter to return to menu");
                    Console.ReadLine();
                    
                }

                else if (menuSelectedByUser == "3")
                {
                    Console.WriteLine("Do you want to exit the program? [yes/no]");
                    exitString = Console.ReadLine();
                }
            


            } while (exitString != "yes");
        }
    }
}
