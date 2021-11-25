using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> emp1 = new Employee<string>();
            emp1.Things = new List<string>() { "ID Badge", "Work Computer", "Company Coffee Mug", "Stationary Supplies", "Assigned Parking Spot" };

            Employee<int> emp2 = new Employee<int>();
            emp2.Things = new List<int>() { 18, 22, 42, 118, 56, 31, 85};

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(emp1.Things[i]);
            }

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(emp2.Things[i]);
            }



            Console.ReadLine();
        }
    }
}
