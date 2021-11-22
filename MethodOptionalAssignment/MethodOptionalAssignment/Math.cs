using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptionalAssignment
{
    class Math
    {
        public static int Add(int x, int y = 8)
        {
            int num1 = x;
            int num2 = y;
            int sum = x + y;
            return sum;
        }
    }
}
