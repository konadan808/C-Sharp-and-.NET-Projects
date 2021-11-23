using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demonstrated polymorphism in the creation of this object, just to ensure I undstood how to successfully impliment it.  Then values are added to the objects' properties
            Person employee1 = new Employee();
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";

            // This calls the method first placed in the abstract class "Person" and then inherrited and defined in the "Employee" class that prints out the object's name properties
            employee1.SayName();

            // Object created from "IQuittable" interface and polymorphed with an inherriting class "Employee"
            IQuittable quitter1 = new Employee();
            
            // This object calls the method first defined in the interface "IQuittable" and then inherrited by the class "Employee". This method prints out text to the screen defined in the "Employee" inherrited method
            quitter1.Quit();

            Console.ReadLine();
        }
    }
}
