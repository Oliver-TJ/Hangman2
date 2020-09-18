using System;

namespace HangmanApp1
{
    class LetterFunction
    {
        public string WordFinder()
        {
            Console.WriteLine("Done");
            return "Done";
        }
    }
    public class Hangman
    {
        public static void Main(string[] args)
        {
            // Ben - enter the words and allow user to choose
            // Ollie - function that loops through the word to see where letters are
            // Main while loop
            LetterFunction n = new LetterFunction();
            string Done = n.WordFinder();
            Console.WriteLine(Done);
        }
    }

    

} 