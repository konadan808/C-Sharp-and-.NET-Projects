using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        // The list of days are contein
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            
            // This code prompts the user to enter a current day of the week and assigns the input to the string variable "currentDay"
            Console.WriteLine("Please enter the current day of the week:");
            string currentDay = Console.ReadLine();

           // This try/catch block parses through the elements of enum "DaysOfTheWeek" and compares them to the user input, and if an exception is found, the catch throws an exception and prints to screen that a valid day of the week was not entered. 
            DaysOfTheWeek day;
            try
            {
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), currentDay);
                Console.WriteLine("You have correctly entered a valid day of the week, " + currentDay);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                // Console.WriteLine(ex.Message); // The system message displayed if the exception is thrown.  It is placed here and commented out for reference as needed in the future
            }

            Console.ReadLine();
        }
            
            

        
        
    }
}
