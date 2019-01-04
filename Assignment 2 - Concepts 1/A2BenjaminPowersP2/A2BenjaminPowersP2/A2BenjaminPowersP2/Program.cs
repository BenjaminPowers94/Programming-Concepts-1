using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment 2 part 2
// By Ben Powers
// Student number 7986250 

namespace A2BenjaminPowersP2
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Ben Powers");
                Console.WriteLine("------------------------------------------");

                // Finding the volume of a sphere

                Console.WriteLine("Finding the volume of a sphere ");
                double r, vol;

                Console.WriteLine("Insert the radius of the sphere");
                r = Convert.ToDouble(Console.ReadLine());

                // calculation 
                vol = 4 * Math.PI * Math.Pow(r, 3) / 3;

                // displaying the outcome of the calculation of a spheres volume 
                Console.WriteLine("The volume of a sphere with the radius of {0} is {1:##.##}", r, vol);
                Console.ReadLine();


                // Finding the volume of a cylinder

                Console.WriteLine("Finding the volume of a cylinder ");
                double radius, height;

                Console.Write("Enter radius: ");
                radius = double.Parse(Console.ReadLine());

                Console.Write("Enter height: ");
                height = double.Parse(Console.ReadLine());

                // calculation
                vol = Math.PI * Math.Pow(radius, 2) * height;

                // displaying the outcome of the calculation of a cylinders volume
                Console.WriteLine("The Volume of a cylinder with the radius {0} and height {1} is {2}", r, height, vol);
                Console.ReadLine();


                // Finding the volume of a Rectangular Prism

                Console.WriteLine("Finding the volume of a Rectangular Prism");
                double LengthOfRectangle, WidthOfRectangle, HeightOfRectangle;

                Console.Write("Enter Length: ");
                LengthOfRectangle = double.Parse(Console.ReadLine());

                Console.Write("Enter Width: ");
                WidthOfRectangle = double.Parse(Console.ReadLine());

                Console.Write("Enter Height: ");
                HeightOfRectangle = double.Parse(Console.ReadLine());

                // calculation
                vol = (LengthOfRectangle * WidthOfRectangle * HeightOfRectangle);

                // displaying the calculation of a Rectangles volume
                Console.WriteLine("The volume of the Rectangular Prism with the length {0} and width {1} and height {2} is {3}", LengthOfRectangle, WidthOfRectangle, HeightOfRectangle, vol); 
                Console.ReadLine(); 

            }

        }
    }
}
