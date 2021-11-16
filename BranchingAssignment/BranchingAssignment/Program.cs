using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro text printed to screen
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");

            // Code asks user to input wight and then uses an if statement to either move forward with collecting dimensions of package or to display a message saying it cannot ship and ends the program.
            Console.WriteLine("Please enter how many pounds your package weighs.");
            float weight = float.Parse(Console.ReadLine());
            if (weight <= 50.0)
            {
                // This code, executed only if package is 50 or less, collects and converts package dimensions
                Console.WriteLine("Please provide the package width");
                float width = float.Parse(Console.ReadLine());
                Console.WriteLine("Please provide the package height");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("Please provide the package length");
                float length = float.Parse(Console.ReadLine());
                
                // This code takes the total dimensions and uses an if/else statement to calculate shipping costs or if the package is too large, a message is displayed saying the package is too large to be shipped.
                float dimensions = width + height + length;
                if (dimensions <= 50 )
                {
                    float totalSize = width * height * length;
                    float shipCost = totalSize * weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + shipCost);
                }
                else
                {
                    Console.WriteLine("We are sorry, your package is too large to be shiped via Package Express.  Goodbye");
                }
            }
            else
            {
                Console.WriteLine("We are sorry, your package is too heavy to be shipped via Package Express.  Goodbye.");
            }
            Console.ReadLine();
        }
    }
}
