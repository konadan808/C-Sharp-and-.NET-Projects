using System;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. User input * 50
            Console.WriteLine("Please enter a number");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);
            int total1 = num1 * 50;
            Console.WriteLine("Your number multiplied by 50 equals: " + total1);


            // 2. User input + 25
            Console.WriteLine("Please enter a number");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);
            int total2 = num2 + 25;
            Console.WriteLine("Your number added to 25 equals: " + total2);

            // 3. User input * 50
            Console.WriteLine("Please enter a number");
            string number3 = Console.ReadLine();
            int num3 = Convert.ToInt32(number3);
            double doub3 = 12.5;
            double total3 = num3 / doub3;
            Console.WriteLine("Your number divided by 12.5 equals: " + total3);

            // 4. User input > 50
            Console.WriteLine("Please enter a number");
            string number4 = Console.ReadLine();
            int num4 = Convert.ToInt32(number4);
            bool status4 = num4 > 50;
            Console.WriteLine("Is your number greater than 50? " + status4);
            
            // 5. User input / 7 to get remainder using modulus "%"
            Console.WriteLine("Please enter a number");
            string number5 = Console.ReadLine();
            double num5 = Convert.ToDouble(number5);
            double total5 = num5 % 7.0;
            Console.WriteLine("Your number divided by 7 has a remainder of: " + total5);
            Console.ReadLine();
        }
    }
}
