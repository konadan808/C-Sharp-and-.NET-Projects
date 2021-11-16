using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program intro text
            Console.WriteLine("Car Insurance Application Questionnaire");
            
            // Questionnaire that collects string values of the user's inputs them and converts them to needed data types, int and bool.
            Console.WriteLine("Please answer the following questions.");
            Console.WriteLine("What is your age?");
            string ageQ = Console.ReadLine();
            int ageInt = Convert.ToInt16(ageQ);
            Console.WriteLine("Have you ever had a DUI? Please answer exactly with \"true\" or \"false\".");
            string duiQ = Console.ReadLine();
            bool duiBool = Convert.ToBoolean(duiQ);
            Console.WriteLine("How many speeding tickets have you received in the past 7 years?");
            string speedQ = Console.ReadLine();
            int speedInt = Convert.ToInt16(speedQ);

            // Setting resulting boolean values to conditions that are compared to the user provided information.
            bool ageResult = ageInt > 15;
            bool duiResult = duiBool == false;
            bool speedResult = speedInt <= 3;

            // Compares the boolean results from previous code block and then compares them to check if they are all true, to meet  the conditions of being covered or not in boolean value.
            bool isQualified = ageResult && duiResult && speedResult;
            Console.WriteLine("Are you qualified for auto insurance coverage?\n" + isQualified);
            Console.ReadLine();
        }
    }
}
