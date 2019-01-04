using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass3
{
    class prorgam
    {
        // Overload 1
        static int SubtractNumbers(int a, int b)
        {   
            // subtracts a - b and returns the results
            return a - b;
        }

        // Overload 2
        static int SubtractNumbers(int a, int b, int c)
        {
            // subtracts a - b - c and returns the results
            return a - b - c;
        }

        // Overload 3
        static int SubtractNumbers(int a, int b, int c, int d)
        {
            // subtracts a - b - c - d and returns the results
            return a - b - c - d;
        }

        static void Main(string[] args)

        {
            // Provides answers to Console Application

            Console.WriteLine(SubtractNumbers(1, 2));
            Console.WriteLine(SubtractNumbers(1, 2, 3));
            Console.WriteLine(SubtractNumbers(1, 2, 3, 4));

        }

    }


}

