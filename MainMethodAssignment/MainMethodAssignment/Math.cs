using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Math
    {
        // This method takes in the user int and the to multiply by int and performas a multiplication operation, returning the result as in int.
        public static int Multiply(int x, int y)
        {
            int num1 = x;
            int num2 = y;
            int result = num1 * num2;
            return result;
        }
        // This method takes in the user double and the to multiply by int and perofrms a multiplication operation, returning the result as a double
        public static double Multiply(double x, double y)
        {
            double num1 = x;
            double num2 = y;
            double result = num1 * num2;
            return result;
        }
        // This method takes in the user input in it's original data type, converts it to an int data type, adds it to the add to int, and returns the result
        public static int Multiply(string x, int y)
        {
            int num3 = Convert.ToInt32(x);
            int num4 = y;
            int result1 = num3 + num4;
            return result1;
        }
        
    }

    
}
