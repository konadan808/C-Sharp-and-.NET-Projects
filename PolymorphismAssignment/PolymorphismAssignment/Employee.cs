using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // The "Employee" class inherits properties and method from "Person" class
    public class Employee : Person, IQuittable
    {
        // This overrides the original method and allows for new code to take be written, adding specified funtionality to the method
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        // Implementing method inherrited by the "IQuittable" interface and setting it to print text to screen
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }
    }
}
