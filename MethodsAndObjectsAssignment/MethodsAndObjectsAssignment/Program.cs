using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This instantiates and initializes an object based on class "Employee" and adds values to properties "FirstName" and "LastName".
            Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student" };

            // This calls the superclass method that was originally in the "Person" class and inherited to class "Employee", which allows the object to use the method.  This method prints the object's name properties to the screen
            employee1.SayName();

            Console.ReadLine();
        }
    }
}
