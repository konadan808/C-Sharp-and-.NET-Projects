using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiated a new "Number" object called "num1" and set a value to its "Amount" property
            Number num1 = new Number();
            num1.Amount = 3.50m;
            // Instantiated a new "Number" object called "num2" using "num1" as a basis and set the value for it
            Number num2 = num1;
            num2.Amount = 19.99m;
            
            // Prints the value of both "num1" and "num2" to screen.
            Console.WriteLine(num1.Amount);
            Console.WriteLine(num2.Amount);

            Console.ReadLine();
        }
    }
}
