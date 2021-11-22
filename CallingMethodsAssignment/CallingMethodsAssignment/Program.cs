using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This instantiates a new object from the class "UserNum" called "num1" that currently doens't have a value
            UserNum num1 = new UserNum();

            // This prompts the user to enter a number to be added by 5, then 18, then 42. It assigns the user input as the value of the object num1
            Console.WriteLine("Please enter a whole number to get the sum of it when its added by 5, then 18, and then by 42.");
            num1.userInput = Convert.ToInt32(Console.ReadLine());
           // This prints out what number the user entered
            Console.WriteLine("You have entered " + num1.userInput);
            // This calls the first method that adds 5 to the user input
            num1 = UserNum.Add5(num1);
            Console.WriteLine(num1.userInput);
            // This calls the second method that adds the first result to 18
            num1 = UserNum.Add18(num1);
            Console.WriteLine(num1.userInput);
            // This calls the third method that adds the second result to 42
            num1 = UserNum.Add42(num1);
            Console.WriteLine(num1.userInput);

            Console.ReadLine();
        }
        
    }
}
