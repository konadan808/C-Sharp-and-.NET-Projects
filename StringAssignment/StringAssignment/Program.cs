using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to answer questions, and assigning those user provided values to variables.
            Console.WriteLine("Hello, please enter your name.");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            // Took the input for color and make the characters all uppercase.  Then this block of code concatenates these user provided strings.
            color = color.ToUpper();
            Console.WriteLine("Hello " + name + " , you are " + age + " years old!  Your favorite color is " + color + "!!!");

            // Created a StringBuilder object and prompted user to ansnwer quetions pertaining to some of their favorite media types.  Then the string values are appended to the StringBuilder object and printed to the screen.
            StringBuilder favoriteMedia = new StringBuilder();
            Console.WriteLine("Enter your favorite movie and how young you were when you first saw it.");
            favoriteMedia.Append(Console.ReadLine());
            Console.WriteLine("State what your favorite book is, when you first read it, and how many times have you read it?");
            favoriteMedia.Append(Console.ReadLine());
            Console.WriteLine("Explain what your favoirte song is, what band plays it, and when the first time you heard it was");
            favoriteMedia.Append(Console.ReadLine());
            Console.WriteLine(favoriteMedia);

            Console.ReadLine();
        }
    }
}
