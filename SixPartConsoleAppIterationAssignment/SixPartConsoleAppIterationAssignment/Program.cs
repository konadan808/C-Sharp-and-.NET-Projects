using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartConsoleAppIterationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part One:
            Console.WriteLine("\nPart One\n");
            // This code creates arrays in order to ask questions, set the arrays that we'll add the answers to, and then to create an emptry array that will collect the user's input
            string[] questions = { "What is your name?", "What is your quest?", "What is the capital of Assyria?" };
            string[] answers = { "Your name is ", "Your quest is ", "The capital of Assyria is " }; // The answer is Assur
            string[] userInput = new string[3];

            // This code asks the questions in the array "questions" and inputs those into the array "userInput"
            Console.WriteLine(questions[0]);
            userInput[0] = Console.ReadLine();
            Console.WriteLine(questions[1]);
            userInput[1] = Console.ReadLine();
            Console.WriteLine(questions[2]);
            userInput[2] = Console.ReadLine();

            // This code takes the array "answers" and adds at the end the array "userInput" and loops through the iterations to add each element of the array.
            for (int i = 0; i < 3; i++)
            {
                answers[i] = answers[i] + userInput[i];
            }

            // This code loops through the array "answers" and prints them to the screen.
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(answers[i]);
            }
            Console.ReadLine();

            // Part Two:
            Console.WriteLine("\nPart Two\n");
            //// This is the code that sends you to eternity inside the Gorge of Eternal Peril.  It is commented out in order to hopefully prevent such a fate
            //while (userInput[2] != "Assur" || userInput[2] != "Nineveh")
            //{
            //    Console.WriteLine("You have been cast into the Gorge of Eternal Peril!!!");
            //}

            // This code has been modified to give you a chance to answer the question correctly and change the element in the "userInput" array to the correct capital of Assyria and prevent you from eternal peril
            while (userInput[2] != "Assur")
            {
                Console.WriteLine("You are about to be cast into the Gorge of Eternal Peril!!!");
                Console.WriteLine("Okay, nobody knows that answer, enter \"Assur\" exactly as written or else you'll be cast into the Gorge of Eternal Peril");
                userInput[2] = Console.ReadLine();
            }
            Console.ReadLine();

            // Part Three:
            Console.WriteLine("\nPart Three\n");
            // This string array is created to hold the names of the brave knights who make it to the Bridge of Death and the Gorge of Eternal Peril
            string[] knights = { "Ser Lancelot", "King Arthur", "Ser Bedevere", "Ser Robin", "Ser Galahad" };

            Console.WriteLine("The knights that arrive at the bridge of death are:");

            // This loop names out those knights from the "knights" array
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(knights[i]);
            }
            Console.ReadLine();

            // This loop iterates through the knights array, modifying the text printed to the screen to show which knights made it across.
            Console.WriteLine("However, the knights who make it across the bridge of death are:");
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(knights[i]);
            }
            Console.ReadLine();


            // Part Four:
            Console.WriteLine("\nPart Four\n");
            // This code creates a string list that contains the names of the Monty Python movies
            List<string> pythonMovies = new List<string>();
            pythonMovies.Add("The Meaning Of Life");
            pythonMovies.Add("The Holy Grail");
            pythonMovies.Add("The Life Of Brian");
            pythonMovies.Add("And Now For Something Completely Different");
            pythonMovies.Add("Live At The Hollywood Bowl");

            // This iterates through the "pythonMovies" list and prints to screen
            Console.WriteLine("Monty Python Movie List");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(pythonMovies[i]);
            }

            // This code makes the values of the list above all lowercase to help with the user input search so that capital letters aren't a factor
            for (int i = 0; i < 4; i++)
            {
                pythonMovies[i] = pythonMovies[i].ToLower();
            }

            // This prompts the user to enter the title of their favorite Monty Python movie, assigns that value to string "favMovie" and then makes the value lowercase
            Console.WriteLine("Please enter the title of your favorite Monty Python movie.");
            string favMovie = Console.ReadLine();
            favMovie = favMovie.ToLower();

            // This loops through the "pythonMovies" list and finds a match to the user provided input variable "favMovie".  One the match is found, it prints the index number to screen.  If no match is found, an error message is printed.
            for (int i = 0; i < 4; i++)
            {
                if (pythonMovies[i] == favMovie)
                {
                    Console.WriteLine("Index: " + pythonMovies.IndexOf(favMovie)
                        );
                }
            }
            if (pythonMovies.IndexOf(favMovie) < 0 || pythonMovies.IndexOf(favMovie) > 4)
            {
                Console.WriteLine("Result not found");
            }
            Console.ReadLine();

            // Part Five:
            Console.WriteLine("\nPart Five\n");
            // This code created a list of some of the items that King Arthur has taken with him on his quest for the holy grail
            List<string> knightSupply = new List<string>();
            knightSupply.Add("Sword");
            knightSupply.Add("Shield");
            knightSupply.Add("Coconut shell");
            knightSupply.Add("Gold crown");
            knightSupply.Add("Holy hand grenade");
            knightSupply.Add("Sword");
            knightSupply.Add("Spare set of non-soild armor for ser Robin");
            knightSupply.Add("Shield");
            knightSupply.Add("Guide to the World's Sparrows book");
            knightSupply.Add("Elderberry Wine");
            knightSupply.Add("Coconut shell");

            // This code lists King Arthur's quest inventory to the screen and prompts you to choose an item exactly as it is written
            Console.WriteLine("King Arthur's knightly inventory.");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(knightSupply[i]);
            }
            Console.WriteLine("Please choose from above an item you'd like to use.  You must enter the item exactly as it is written.");
            string userItem = Console.ReadLine();

            // This for loop iterates through the "knightSupply" list to compare it to the "userItem" that the user input and prints out either the index number and item, or informs you that you didn't follow directions and you shall not take part in the quest for the Holy Grail
            for (int i = 0; i < 11; i++)
            {
                if (knightSupply[i].Contains(userItem))
                {
                    Console.WriteLine("Index: " + i + ": " + userItem);
                }
            }
            if (knightSupply.IndexOf(userItem) < 0 || knightSupply.IndexOf(userItem) > 10)
            {
                Console.WriteLine("You did not enter the item exactly as it is written! No grail quest for you!");
            }
            Console.ReadLine();

            // Part Six:
            Console.WriteLine("\nPart Six\n");

            // This foreach loop iterates through the "knightSupply" list and compares it to each value in it to check for duplicates.  When it finds them, it prints that item with additional text, otherwise it just prints the items.
            foreach (string item in knightSupply)
            {
                if (knightSupply.Contains(item) && knightSupply.Count(x => x == item) > 1)
                {
                    Console.WriteLine(item + ": This item is a duplicate item.");
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}
