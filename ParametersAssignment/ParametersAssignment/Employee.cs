using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    public class Employee<T> // This class has been set to generic using "<T>"  This allows an object of any data type to be instantiated using Employee
    {
        public List<T> Things { get; set; } // This allows an instantiated object to create a property list in which values can be any data type
    }
}
