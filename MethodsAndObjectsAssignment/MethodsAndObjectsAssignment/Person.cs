using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    // Class "Person" created to model the creation of objects that have the string property of "FirstName" and "LastName" as well as a method to print out those properties
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    public void SayName()
    {
        Console.WriteLine("Name: " + FirstName + " " + LastName);

    }
        
    }
}
