using System;

namespace HangmanApp1
{
    public class Hangman
    {
        public bool Contains(String str)
        {
            return true;
        }

        public Array WordCreator()
        {
            // input
            Console.WriteLine("Enter the word you want to guess");
            string EnterWord = Console.ReadLine();
            string[] LetterList = new string[EnterWord.Length];
            return LetterList;
        }

        public static void Main(string[] args)
        {
            // Ben           - enter the words and allow user to choose
            // Ollie TJ      - function that loops through the word to see where letters are
            // Ollie Blom    - Main while loop
            
            
        }
    }
}