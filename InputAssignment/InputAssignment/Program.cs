using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code prompts the user to enter a number and sets their input to the string variable "userNum"
            Console.WriteLine("Hello, plese enter a number.");
            string userNum = Console.ReadLine();
            
            // This line of code uses a relative path method in which it goes back three directories, then into the "log" directory and writes a txt file that contains the user input
            File.WriteAllText(@"..\..\..\log\userNum.txt", userNum);

            // This line of code uses that same relative path to read the "userNum.txt" file we just created and the "Console.WriteLine()" prints that file to the console
            Console.WriteLine("Your number is " + File.ReadAllText(@"..\..\..\log\userNum.txt"));

            Console.ReadLine();
        }
    }
}
