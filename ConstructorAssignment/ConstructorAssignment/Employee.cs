using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Employee
    {
        // This is the Constructor Call Chain
        public Employee() : this("John", "Doe", 404)
        {
        }

        // This is the class constructor
        public Employee(string fName, string lName, int empNum)
        {
            FName = fName;
            LName = lName;
            EmpNum = empNum;
        }

        // These are the properties of class Employee
        public string FName { get; set; }
        public string LName { get; set; }
        public int EmpNum { get; set; }
    }
    
}
