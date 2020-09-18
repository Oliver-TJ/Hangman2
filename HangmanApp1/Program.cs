using System;

namespace HangmanApp1
{
    // creating the class
    class LetterFunction
    {
        // defining the function
        public Array WordFinder()
        {
            string[] end = new string[] {"D","o","n","e"};
            return end;
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
            LetterFunction lf = new LetterFunction();
            Array Done = lf.WordFinder();
            Console.WriteLine(Done);
        }
    }

    

} 