using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    public class Math
    {
        // This code sets the int property for a Math class object
        public int userNum { get; set; }

        // This code takes an object parameter and performs a math operation and displays the result to the screen.
        public static void Divide(int x)
        {
            int num1 = x;
            int num2 = 2;
            int result = num1 / num2;
            Console.WriteLine(x + " divided by 2 equals " + result);
        }
        // This method has an output parameter that counts how many times the user provided integer was cycled
        public static void CountUp(int x, out int timesCycled)
        {
            timesCycled = 0;
            int num1 = x;
            for (int i = 1; i < 6; i++)
            {
                timesCycled++;
                Console.WriteLine(num1 + i);

            }
            
        }
    }
}
