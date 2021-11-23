using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    // Class "Employee" is created to inherit the properties and method from the "Person" class and adds an additional property int "Id" in order to model the creation of objects
    public class Employee : Person
    {
        public int Id { get; set; }
    }
}
