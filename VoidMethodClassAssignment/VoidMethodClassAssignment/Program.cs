using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code prompts the user to enter two numbers, one at a time with the expected outcome stated to the user.  User input is converted to int data type.
            Console.WriteLine("Please enter a number to add by 5:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plese entere a second number to display to the screen:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            // In this code, the class "Math" metthod of "AddAndPrint" is called with the user input passed along as parameters and the results are printed to the screen
            Math.AddAndPrint(num1, num2);

            Console.ReadLine();
        }
    }
}
