using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodClassAssignment
{
    public class Math
    {
        // This method takes in the parameters entered by the user, in which the first number has a math operation done to it and the second number is simply displayed.  Nothing is returned, instead the method is called by the main method.
        public static void AddAndPrint(int x, int y)
        {
            int num1 = x;
            int sum = x + 5;
            int num2 = y;
            Console.WriteLine(x + " plus 5 equals " + sum);
            Console.WriteLine("The second number you entered is the number " + num2);
        }
    }
}
