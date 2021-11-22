using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptionalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code prompts the user to enter a number and converts their input to an int data type
            Console.WriteLine("Please enter a number:");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            
            // This code asks if the user if they'd like to enter a second number, of which the answer is put to lower case and then used to determine a branch path
            Console.WriteLine("If you'd like to enter a second number, please type \"yes\" or \"no\":");
            string yesOrNo = Console.ReadLine();
            yesOrNo = yesOrNo.ToLower();
            
            // This code occurs if the user inputs "yes" and wants to enter a second number.  Their input is converted to an int data type, both inputs are passed as parameters and the class method "Add" is called to perfom an add operation, and prints out the result to screen
            if (yesOrNo == "yes")
            {
                Console.WriteLine("Please enter a second number:");
                int userNum2 = Convert.ToInt32(Console.ReadLine());
                int sum = Math.Add(userNum1, userNum2);
                Console.WriteLine(userNum1 + " plus " + userNum2 + " equals " + sum);
            }

            // This code occurs if the user inputs "no". Their first input is passed as a paramter and the class method "Add" is called to perfom an add operation using a default second parameter defined in the method, and prints out the result to screen
            else
            {
                int sum = Math.Add(userNum1);
                Console.WriteLine(userNum1 + " plus 8 equals " + sum);
            }
            
            Console.ReadLine();
        }
    }
}
