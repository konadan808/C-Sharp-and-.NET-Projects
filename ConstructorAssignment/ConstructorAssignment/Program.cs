using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constant created as a string data type variable, "Initech" is the value given to this varaible
            const string coName = "Initech";

            // This block creates instantiations of the Employee class, the first creates an object with the default values given to the properties of the object, and the rest creates an object with the given values provided by the programmer
            Employee emp1 = new Employee();
            Employee emp2 = new Employee() { FName = "Peter", LName = "Gibbons", EmpNum = 42 };
            Employee emp3 = new Employee() { FName = "Bill", LName = "Lumbergh", EmpNum = 666 };
            Employee emp4 = new Employee() { FName = "Michael", LName = "Bolton", EmpNum = 25 };
            Employee emp5 = new Employee() { FName = "Tom", LName = "Smykowski", EmpNum = 83 };
            Employee emp6 = new Employee() { FName = "Bob", LName = "Porter", EmpNum = 71 };
            Employee emp7 = new Employee() { FName = "Bob", LName = "Slydell", EmpNum = 72 };
            Employee emp8 = new Employee() { FName = "Samir", LName = "Nagheenanajar", EmpNum = 58 };
            Employee emp9 = new Employee() { FName = "Milton", LName = "Waddams", EmpNum = 1 };
            

            // This code prints out a greeting to the user via console, using the const variable "coName" to call the compnay name.  It asks the user if they'd like to see a list of employee informaion
            Console.WriteLine("Welcome to {0}!  Would you like to review our employees' information? Please type \"yes\" or \"no\"", coName);
            var answer = Console.ReadLine().ToLower();

            // This if/else block of code.  If the user enters yes, the employee information is printed to the concolse.  Otherwise, the program will log you out.
            if (answer == "yes")
            {
                Console.WriteLine(emp1.FName + " " + emp1.LName + " ID # " + emp1.EmpNum);
                Console.WriteLine(emp2.FName + " " + emp2.LName + " ID # " + emp2.EmpNum);
                Console.WriteLine(emp3.FName + " " + emp3.LName + " ID # " + emp3.EmpNum);
                Console.WriteLine(emp4.FName + " " + emp4.LName + " ID # " + emp4.EmpNum);
                Console.WriteLine(emp5.FName + " " + emp5.LName + " ID # " + emp5.EmpNum);
                Console.WriteLine(emp6.FName + " " + emp6.LName + " ID # " + emp6.EmpNum);
                Console.WriteLine(emp7.FName + " " + emp7.LName + " ID # " + emp7.EmpNum);
                Console.WriteLine(emp8.FName + " " + emp8.LName + " ID # " + emp8.EmpNum);
                Console.WriteLine(emp9.FName + " " + emp9.LName + " ID # " + emp9.EmpNum);

            }
            else
            {
                Console.WriteLine("Okay, goodbye.  Logging you out...");
            }

            Console.ReadLine();
        }
    }
}
