using System;

namespace MathAndComparisonOperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro to program line, simply prints out name of program
            Console.WriteLine("Anonymous Income Comparison Program");
            
            // Addresses 1st employee, requests pay rate and hours worked and collects answers as string data types, then converts them to float data types
            Console.WriteLine("Employee 1: Please answer the following questions.");
            Console.WriteLine("What is your hourly rate?");
            string hourRate1 = Console.ReadLine();
            float empRate1 = float.Parse(hourRate1);
            Console.WriteLine("How many hours do you work per week?");
            string hoursWorked1 = Console.ReadLine();
            float empHours1 = float.Parse(hoursWorked1);

            // Addresses 2nd employee, requests pay rate and hours worked and collects answers as string data types, then converts them to float data types
            Console.WriteLine("Employee 2: Please answer the following questions.");
            Console.WriteLine("What is your hourly rate?");
            string hourRate2 = Console.ReadLine();
            float empRate2 = float.Parse(hourRate2);
            Console.WriteLine("How many hours do you work per week?");
            string hoursWorked2 = Console.ReadLine();
            float empHours2 = float.Parse(hoursWorked2);

            float weeksInYear = 52.1429f;
            // Calculates Employee 1's salary by multiplying their hourly rate to hours worked during a week and multiplying the result to how many weeks are in a year, 52.1429.
            float empWeek1 = empRate1 * empHours1;
            float empSalary1 = empWeek1 * weeksInYear;
            Console.WriteLine("Annual salary for Employee 1 is: \n" + empSalary1);

            // Calculates Employee 2's salary by multiplying their hourly rate to hours worked during a week and multiplying the result to how many weeks are in a year, 52.1429.
            float empWeek2 = empRate2 * empHours2;
            float empSalary2 = empWeek2 * weeksInYear;
            Console.WriteLine("Annual salary for Employee 2 is: \n" + empSalary2);

            // Prints out the boolean result of if Employee 1 makes more than Employee 2
            bool salaryStatus = empSalary1 > empSalary2;
            Console.WriteLine("Does Employee 1 make more than Employee 2? \n" + salaryStatus);
        }
    }
}
