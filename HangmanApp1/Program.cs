using System;

namespace DefaultNamespace
{
    public class Hangman
    {
        public static void Main(string[] args)
        {
            // Ben - enter the words and allow user to choose
            // Ollie - function that loops through the word to see where letters are
            // Main while loop
            Console.WriteLine(new LetterFunction());
        }
    }

    class LetterFunction
    {
        public string WordFinder(string word)
        {
            string result = "Done";
            return result;
        }
    }

} 