using System;

namespace HangmanApp1
{
    // creating the class
    class LetterFunction
    {
        // defining the function
        public string WordFinder()
        {
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
            
            
            // returning the function
            LetterFunction n = new LetterFunction();
            string Done = n.WordFinder();
            Console.WriteLine(Done);
        }
    }

    

} 