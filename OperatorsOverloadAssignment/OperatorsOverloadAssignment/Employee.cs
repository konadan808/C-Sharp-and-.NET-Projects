using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloadAssignment
{
    // The "Employee" class inherits properties and method from "Person" class
    public class Employee : Person
    {
        public int Id { get; set; }
        // This overrides the original method and allows for new code to take be written, adding specified funtionality to the method
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        //  This overloads the "==" operator, in which only the object name is needed as a paramter, as the "Id" property is defined in this code as what is to be compared for the objects passed in
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Id.Equals(employee2.Id))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (!employee1.Id.Equals(employee2.Id))
            {
                return true;
            }
            return false;
        }
        
        
    }
}
