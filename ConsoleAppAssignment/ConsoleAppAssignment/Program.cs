using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // App intro text is printed.  then the iteration variable is set as is a new, empty list
            Console.WriteLine("Your Top Ten Favorite Video Games!!!");
            int i = 1;
            var gameList = new List<string>();
            
            // The do while code in this block prompts the user to enter their favorite video game titles and adds them to the emptly list until 10 entries are entered
            do
            {
                Console.WriteLine("Entry " + i + ": Please enter a video game title.");
                gameList.Add(Console.ReadLine());
                i++;
            }
            while (i <= 10);

            // Here the iteration value "l" is set to 0 and the code will print out the list of games that the user entered until all items in the list have been printed.
            int l = 0;
            Console.WriteLine("The list of games you have entered are:");
            while (l < gameList.Count)
            
            {
                Console.WriteLine(gameList[l]);
                l++;
            }
            //Allows the console to stay open and display all the data without closing on its own.
            Console.ReadLine();

        }
    }
}
