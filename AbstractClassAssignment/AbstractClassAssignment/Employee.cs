using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{

    // The "Employee" class inherits properties and method from "Person" class
    public class Employee : Person
    {
        // This overrides the original method and allows for new code to take be written, adding specified funtionality to the method
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
