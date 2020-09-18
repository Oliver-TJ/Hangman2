using System;

namespace HangmanApp1
{
    // creating the class
    class LetterFunction
    {
        // defining the function
        public Array WordFinder()
        {
            string[] end = new string[] {"Done"};
            return end;
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