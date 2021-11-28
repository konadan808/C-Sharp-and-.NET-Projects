using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Date_TimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This block of code instantiates a DateTime object called "timeNow", sets the value using DateTime.Now for the current time, then prints the value to the console.
            DateTime timeNow = new DateTime();
            timeNow = DateTime.Now;
            Console.WriteLine("The current date and time is " + timeNow);

            // This code prompts the user to enter a number, then converts their input to the double data type variable "userNum"
            Console.WriteLine("Please enter a number:");
            double userNum = Convert.ToDouble(Console.ReadLine());

            // This block of code instantiates a new DateTime object and gives it the value of "timeNow" plus the user input, using the .AddHours method to add the user input
            DateTime newTime = timeNow.AddHours(userNum);
            
            // This code prints what the time will be using the DateTime object "newTime" and the user input "userNum" to tell you what the time will be in the user specified number 
            Console.WriteLine("The time will be " + newTime + " in " + userNum + " hours.");

            Console.ReadLine();
        }
    }
}
