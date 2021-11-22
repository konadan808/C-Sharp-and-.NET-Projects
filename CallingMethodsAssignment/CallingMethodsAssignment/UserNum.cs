using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    // Class created that has the property of a single int data type
    public class UserNum
    {
        public int userInput { get; set; }
        // First Method that adds 5 to the user input
        
        public static UserNum Add5(UserNum num1)
        {
            int result = num1.userInput + 5;
            num1.userInput = result;
            return num1;
        }
        // Second method that takes the result of the first method and adds 18 to it
        public static UserNum Add18(UserNum num1)
        {
            int result = num1.userInput + 18;
            num1.userInput = result;
            return num1;
        }
        // Third method that take the result of the second method and adds 42 to it
        public static UserNum Add42(UserNum num1)
        {
            int result = num1.userInput + 42;
            num1.userInput = result;
            return num1;
        }
    }

}
