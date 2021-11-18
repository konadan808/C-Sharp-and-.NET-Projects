using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code here created an array that has the name and summary of each movie.
            string[] movieArray = new string[5];
            movieArray[0] = "Ghostbusters: Afterlife\nWhen a single mother and her two children move to a new town, they soon discover they have a connection to the original Ghostbusters and the secret legacy their grandfather left behind.";
            movieArray[1] = "No Time To Die\nJames Bond is enjoying a tranquil life in Jamaica after leaving active service. However, his peace is short-lived as his old CIA friend, Felix Leiter, shows up and asks for help. The mission to rescue a kidnapped scientist turns out to be far more treacherous than expected, leading Bond on the trail of a mysterious villain who's armed with a dangerous new technology.";
            movieArray[2] = "Venom: Let There Be Carnage\nEddie Brock is still struggling to coexist with the shape-shifting extraterrestrial Venom. When deranged serial killer Cletus Kasady also becomes host to an alien symbiote, Brock and Venom must put aside their differences to stop his reign of terror.";
            movieArray[3] = "Dune\nPaul Atreides, a brilliant and gifted young man born into a great destiny beyond his understanding, must travel to the most dangerous planet in the universe to ensure the future of his family and his people. As malevolent forces explode into conflict over the planet's exclusive supply of the most precious resource in existence, only those who can conquer their own fear will survive.";
            movieArray[4] = "Eternals\nThe Eternals, a race of immortal beings with superhuman powers who have secretly lived on Earth for thousands of years, reunite to battle the evil Deviants.";

            // This code creates the number of tickets purchased
            int[] tickets = { 1, 2, 3, 4, 5, 6 };

            // This array contains string values representing movie times
            string[] movieTimes = { "11:00AM", "1:30PM", "4:00PM", "6:30PM", "9:00PM", "11:30PM"};

            // Intro text printed to screen
            Console.WriteLine("Welcome to Consolidated Theaters Online Movie Ticket Portal!");
            Console.WriteLine("In order to purchase the tickets for the movie you want to see, please answer the following questions.");
            
            // Prompts user to enter the number that represents what movie they'd like to see, and creates an int value for comparrison
            Console.WriteLine("Please enter 1 through 5 for the movie you'd like to see: \n1) Ghostbusters: Afterlife\n2) No Time To Die\n3) Venon: Let There Be Carnage\n4) Dune\n5) Eternals");
            int movieSelected = Convert.ToInt16(Console.ReadLine());

            // Prompts user to enter the number that represents how many tickets are to be purchased as well as telling them 6 is the max, and creates an int value for comparrison
            Console.WriteLine("Please select how many tickets you'd like to purchase.  Seating is limited.  Limit 6 tickets per customer.");
            int ticketsBought = Convert.ToInt16(Console.ReadLine());

            // // Prompts user to enter the number that represents what movie showtime they'd like to view the movie at, and creates an int value for comparrison
            Console.WriteLine("Please enter 1 through 6 for the showtime you would like to see your selected movie at:\n1) 11:00AM\n2) 1:30PM\n3) 4:00PM\n4) 6:30PM\n5) 9:00PM\n6)11:30PM");
            int timeSelected = Convert.ToInt16(Console.ReadLine());

            // Text printed to indicate the following choices that the user has selected
            Console.WriteLine("Please see below to confirm the movie, how many tickets to be purchased, and the showtime that you have selected:");

            // These if/else if/else statements print out the associated "movieArray" index with the int value "movieSelected" the user entered previously
            if (movieSelected == 1)
                Console.WriteLine("You have chosen: " + movieArray[0]);
            else if (movieSelected == 2)
                Console.WriteLine("You have selected: " + movieArray[1]);
            else if (movieSelected == 3)
                Console.WriteLine("You have selected: " + movieArray[2]);
            else if (movieSelected == 4)
                Console.WriteLine("You have selected: " + movieArray[3]);
            else if (movieSelected == 5)
                Console.WriteLine("You have selected: " + movieArray[4]);
            else
                Console.WriteLine("You have entered a non-existent movie listing.");

            // These if/else if/else statements print out the associated "tickets" index with the int value "ticketsBought" the user entered previously
            if (ticketsBought == 1)
                Console.WriteLine(tickets[0] + " ticket to be purchased");
            else if (ticketsBought == 2)
                Console.WriteLine(tickets[1] + " tickets to be purchased");
            else if (ticketsBought == 3)
                Console.WriteLine(tickets[2] + " tickets to be purchased");
            else if (ticketsBought == 4)
                Console.WriteLine(tickets[3] + " tickets to be purchased");
            else if (ticketsBought == 5)
                Console.WriteLine(tickets[4] + " tickets to be purchased");
            else if (ticketsBought == 6)
                Console.WriteLine(tickets[5] + " tickets to be purchased");
            else
                Console.WriteLine("You have entered an incorrect quantity.");

            // These if/else if/else statements print out the associated "movieTimes" index with the int value "timeSelected" the user entered previously
            if (timeSelected == 1)
                Console.WriteLine("You have selected the showtime of " + movieTimes[0]);
            else if (timeSelected == 2)
                Console.WriteLine("You have selected the showtime of " + movieTimes[1]);
            else if (timeSelected == 3)
                Console.WriteLine("You have selected the showtime of " + movieTimes[2]);
            else if (timeSelected == 4)
                Console.WriteLine("You have selected the showtime of " + movieTimes[3]);
            else if (timeSelected == 5)
                Console.WriteLine("You have selected the showtime of " + movieTimes[4]);
            else if (timeSelected == 6)
                Console.WriteLine("You have selected the showtime of " + movieTimes[5]);
            else
                Console.WriteLine("You have selected an incorrect showtime.");

            Console.ReadLine();
        }
    }
}
