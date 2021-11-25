using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpresssionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here, we create a list of instantiated objects that are added upon the creation of the list.
            List<Employee> employees = new List<Employee>()
            {
                new Employee { FName = "Peter", LName = "Gibbons", IdNum = 42 },
                new Employee { FName = "Bill", LName = "Lumbergh", IdNum = 666 },
                new Employee { FName = "Michael", LName = "Bolton", IdNum = 25 },
                new Employee { FName = "Tom", LName = "Smykowski", IdNum = 83 },
                new Employee { FName = "Bob", LName = "Porter", IdNum = 71 },
                new Employee { FName = "Bob", LName = "Slydell", IdNum = 72 },
                new Employee { FName = "Joe", LName = "Smith", IdNum = 46 },
                new Employee { FName = "Samir", LName = "Nagheenanajar", IdNum = 58 },
                new Employee { FName = "Joe", LName = "Portwood", IdNum = 105 },
                new Employee { FName = "Milton", LName = "Waddams", IdNum = 1 }
            };

            // This foreach loop goes through the list of "employees" and compares the ".FName" values to "Joe" and creates a list of those "Employee" objects that have matching property values, then prints that list to screen.
            List<Employee> averageJoe = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FName == "Joe")
                {
                    averageJoe.Add(employee);
                }
            }
            foreach (Employee joe in averageJoe)
            {
                Console.WriteLine(joe.FName + " " + joe.LName + ": " + joe.IdNum);
            }

            Console.WriteLine("\n");

            // This lambda expression performs the same action as the above foreach loop
            List<Employee> JoeList = employees.Where(x => x.FName == "Joe").ToList();
            foreach (Employee employee in JoeList)
            {
                Console.WriteLine(employee.FName + " " + employee.LName + ": " + employee.IdNum);
            }
            Console.WriteLine("\n");

            // This code uses a lambda expression to create a list of Employees who have an "IdNum" property greater than 5.  It then prints the new list to screen
            List<Employee> greaterId = employees.Where(x => x.IdNum > 5).ToList();
            foreach (Employee empID in greaterId)
            {
                Console.WriteLine(empID.FName + " " + empID.LName + ": " + empID.IdNum);
            }



        

            Console.ReadLine();
        }
    }
}
