using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // List created to store int data types
            List<int> numList = new List<int>();
            numList.Add(18);
            numList.Add(24);
            numList.Add(126);
            numList.Add(82);
            numList.Add(462);
            numList.Add(78);
            numList.Add(42);
            numList.Add(56);

            // try/catch block created to create exception errors for the foreach loop.
            try
            {
                // Loops through the list "numList" and prompts user to enter a number to divde each element of the "numList" by the number the user enters and displays the results to the screen
                foreach (int num in numList)
                {

                    Console.WriteLine("Please enter a number to divide " + num + " by:");
                    int userNum = Convert.ToInt32(Console.ReadLine());
                    int result = num / userNum;
                    Console.WriteLine(num + " divided by " + userNum + " equals " + result + "\n");
                }
            }
            // This catch will recognize when the user inputs a non-int data type
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + " You have entered an incorrectly formatted entry.");
            }
            // This catch will recognize when the user tries to divide the number by 0
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message + " You are not able to divide by 0.");
            }
            // This catch will recognize any unspecified error type and print to screen what the system error message is
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Allows the program to continue to execute code
            finally
            {
                
            }
            Console.WriteLine("This program has been successfully completed.");
            Console.ReadLine();

        }
    }
}
