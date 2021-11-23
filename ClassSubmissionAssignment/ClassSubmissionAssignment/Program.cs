using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math num1 = new Math();

            // This code prompts the user to enter a number they'd like to see divided by 2 and calls on a void method to perfrom the math operation as well as display the result
            Console.WriteLine("Please enter a number to be divided by 2:");
            num1.userNum = Convert.ToInt32(Console.ReadLine());
            Math.Divide(num1.userNum);

            // This code prompts the user to enter a number they'd like to see added by 5 and calls on the method of a static class
            Console.WriteLine("Please enter a number to see it added by 5:");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userNum1 + " plus 5 equals " + MathStatic.Add5(userNum1));

            // This code demonstrated the use of an out paramter in the method used in this block and prints out the count below
            int timesCycled = 0;
            Console.WriteLine("Please enter a number you'd like to have 1 added to five times:");
            int userNum3 = Convert.ToInt32(Console.ReadLine());
            Math.CountUp(userNum3, out timesCycled);

            // This code prints out the out paramter result associated with the Math.CountUp method
            Console.WriteLine("This code was cycled " + timesCycled + " times.");

            // This code uses method overload to add two variables and print the result to the screen
            Overload.Add(2, 5);
            Overload.Add(3.5, 2.14);
            Overload.Add("Hello, ", "World!");

            Console.ReadLine();
        }
    }
}
