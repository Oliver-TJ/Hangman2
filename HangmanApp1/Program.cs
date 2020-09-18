using System;

namespace HangmanApp1
{
    // creating the class
    class LetterFunction
    {
        // defining the function
        public Array WordFinder()
        {
            for (int j = 0; j < mysteryWord.Length; j++)
            {
                if (playerGuess == mysteryWord[j])
                    guess[j] = playerGuess;
                return null;
            }
        }

        public Array WordCreator()
        {
            // input
            Console.WriteLine("Enter the word you want to guess");
            string EnterWord = Console.ReadLine();
            string[] LetterList = new string[EnterWord.Length];

        }
    }
    public class Hangman
    {
        public static void Main(string[] args)
        {
            // Ben           - enter the words and allow user to choose
            // Ollie TJ      - function that loops through the word to see where letters are
            // Ollie Blom    - Main while loop
            
            
            // returning the function
            LetterFunction lf = new LetterFunction();
            Array Done = lf.WordFinder();
            
            // prints the array
            // similar to         for i in range(x,y):
            //                        print(array[i])
            
            foreach(var item in Done)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
} 