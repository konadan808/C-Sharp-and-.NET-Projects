using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    public class Overload
    {
        // Method overload that adds ints
        public static void Add(int x, int y)
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }
        // Method overload that adds strings
        public static void Add(string x, string y)
        {
            string answer = x + y;
            Console.WriteLine(answer);
        }
        // Method overload that adds doubles
        public static void Add(double x, double y)
        {
            double answer = x + y;
            Console.WriteLine(answer);
        }
    }
}
