using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introductory text printed to screen
            Console.WriteLine("The Tech Academy\n");
            Console.WriteLine("Student Daily Report\n");
            Console.WriteLine("Please answer the following questions\n");
            
            // Code to ask first, last name and then a variable to combine them with a space in between
            Console.WriteLine("What is your first name?");
            string fName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lName = Console.ReadLine();
            Console.WriteLine("What course are you currently on?");
            string fullName = fName + " " + lName;

            // Code to ask and collect current course
            string cName = Console.ReadLine();

            // The code here gets the page number in string format from the user, then converts it to an int data type
            Console.WriteLine("What page or step are you currently on?");
            string pNum = Console.ReadLine();
            int pageNum = Convert.ToInt16(pNum);

            // Here we get the string input of true or false and convert it to a bool data type
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string helpAnswer = Console.ReadLine();
            bool helpStatus = Convert.ToBoolean(helpAnswer);

            // We gather input from the user on any experiences and feed back in string form
            Console.WriteLine("Were there any postitive experiences you'd like to share? Please give specifics");
            string expSpec = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feedback = Console.ReadLine();

            // Here we get the string value of how many hours the user input, and then convert it to the int data type
            Console.WriteLine("How many hours did you study today?");
            string hourAnswer = Console.ReadLine();
            int studyHours = Convert.ToInt16(hourAnswer);

            // Here we create a summary of the user's answers and print them out clearly, in the data type they are meant to be saved as.
            Console.WriteLine("Summary of your answers are:\nName: " + fullName + "\nCurrent Course: " + cName + "\nCurrent Page #: " + pageNum + "\nHelp needed status: " + helpStatus + "\nPositive Experiences: " + expSpec + "\nFeedback: " + feedback + "\nHours Studied: " + studyHours);

            // String printed to screen upon finishing daily report and end of program
            Console.WriteLine("\nThank you for your answers.  An instructor will respond to this shortly.  Have a great day!");
            
        }
    }
}
