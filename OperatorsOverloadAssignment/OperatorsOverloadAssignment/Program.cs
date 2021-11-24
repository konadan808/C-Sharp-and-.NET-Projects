using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloadAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code instantiates objects and gives their properties values
            Employee employee1 = new Employee() { FirstName = "Luke", LastName = "Skywalker", Id = 82 };
            Employee employee2 = new Employee() { FirstName = "Han", LastName = "Solo", Id = 42 };
            Employee employee3 = new Employee() { FirstName = "Anikin", LastName = "Skywalker", Id = 28 };
            Employee employee4 = new Employee() { FirstName = "Ben", LastName = "Solo", Id = 28 };

            // Calls the object method that prints the "FirstName" and "LastName" properties to screen
            employee1.SayName();
            employee2.SayName();
            employee4.SayName();
            employee3.SayName();

            // This if/else statement compares the Employee objects to see if they are equal in value.  Thanks to the "==" overloading, no additional paramters other than the object name as opposed to the object name and "Id" property are passed to the method.  Text is printed depending on if the "Id" values are the same or different.
            if (employee1 == employee2)
            {
                Console.WriteLine("These employees have the same ID number.");
            }
            else
            {
                Console.WriteLine("These employees have different ID numbers.");
            }

            if (employee3 == employee4)
            {
                Console.WriteLine("These employees have the same ID number.");
            }
            else
            {
                Console.WriteLine("These employees have different ID numbers.");
            }

            Console.ReadLine();

        }
    }
}
