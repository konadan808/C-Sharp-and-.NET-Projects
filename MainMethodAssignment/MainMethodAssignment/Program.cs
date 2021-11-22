using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This block prompts user to enter a whole number to be multiplied by 5, puts the input into int form, calls the class method to multiply, then prints out the result
            Console.WriteLine("Please enter a whole number you'd like to see multiplie by 5.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int result = Math.Multiply(userNum, 5);
            Console.WriteLine(userNum + " multiplied by 5 equals " + result);

            // This block prompts user to enter a decimal number to be multiplied by 3, puts the input into double form, calls the class method to multiply, then prints out the result
            Console.WriteLine("Now please enter a decimal number that you'd like to see multiplied by 3.");
            double userNum2 = Convert.ToDouble(Console.ReadLine());
            double result1 = Math.Multiply(userNum2, 3);
            Console.WriteLine(userNum2 + " multiplied by 3 equals " + result1);

            // This block prompts user to enter a number to be added by 8, calls the class method to multiply which takes the user string input it and converts it within the class method to an int, then prints out the result
            Console.WriteLine("And now please enter a whole number you'd like to see added to by 8");
            string userNum3 = Console.ReadLine();
            int result3 = Math.Multiply(userNum3, 8);
            Console.WriteLine(userNum3 + " plus 8 equals " + result3);





            Console.ReadLine();
        }
    }
}
