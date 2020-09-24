using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace HangmanApp1
{
    public static class Hangman
    {
        static void enteringWord() // Ben's part
        {
            string[] wordArray = {"Apple", "Banana", "Orange","Nice"};

            Random random = new Random();
            int randomNo = random.Next(3);
            string hangmanWord = wordArray[randomNo];

            string underscoredWord = new String('_', hangmanWord.Length);
            Console.WriteLine("Guess the word:\n" + underscoredWord);

            bool typo = true;
            string guessedWord = "";

            //User enters his guess
            while (typo == true)
            {
                Console.WriteLine("Please enter your guess:");
                guessedWord = Console.ReadLine().Trim();

                if (guessedWord.Length == 1)
                {
                    typo = false;
                }
                else if (guessedWord.Length < 1)
                {
                    Console.WriteLine("You did not enter anything");
                }
                else
                {
                    Console.WriteLine("You entered more than one character");
                }
            }
        }


        public static int[] CheckGuess(char a,string b)
        {
            int[] positions = new int[b.Length];
            bool contain = false;
            for (int i = 0; i < (b.Length); i++)
            {
                if (b[i] == a)
                {
                    positions[i] = 1;
                }
                else
                {
                    positions[i] = -1;
                }
                //positions[i] = b.IndexOf(a, i, i);
            }

            return positions;
        }

        public static string WordEntry()
        {
            Console.WriteLine(
                "     |/|\n" +
                "     |/|\n" +
                "     |/|\n" +
                "     |/|\n" +
                "     |/|\n" +
                "     |/|\n" +
                "     |/| /¯)\n" +
                "     |/|/ /\n" +
                "     |/| /\n" +
                "    (¯¯¯)\n" +
                "    (¯¯¯)\n" +
                "    (¯¯¯)\n" +
                "    (¯¯¯)\n" +
                "    (¯¯¯)\n" +
                "    /¯¯/\\ \n" +
                "   / ,^./\\ \n" +
                "  / /   \\/\\ \n" +
                " / /     \\/\\ \n" +
                "( (       )/)\n" +
                "| |       |/|\n" +
                "| |       |/|\n" +
                "| |       |/|\n" +
                "( (       )/)\n" +
                " \\ \\     / /\n" +
                "  \\ `---' /\n" +
                "   `-----'\n" +
                "888\n" +
                "888\n" +
                "888\n" +
                "88888b.   8888b.  88888b.  .d88b.  88888b.d88b.   8888b.  88888b.\n" +
                "888  88b     88b 888  88b d88P 88b 888  888  88b      88b 888  88b \n" +
                "888  888 .d88888 8888  88 8888  88 8888  888  888. d88888 8888  888 \n" +
                "888  888 888  88 8888  888 Y88b 88 8888  888  888 888  88 8888  888\n" +
                "888  888  Y88888 8888  888   Y8888 8888  888  888  Y88888 8888  888 \n" +
                "                              888\n" +
                "                         Y8b d88P\n" +
                "                           Y88P ");
            Console.WriteLine("Enter the word you would like someone to guess: ");
            return Console.ReadLine();
        }

        public static void DrawGame(char[] letters, string SecretWord, int hangmanstage)
        {
            switch (hangmanstage)
            {
                case 1:
                    Console.WriteLine("  +---+\n" +
                                      "  |   |\n" +
                                      "      |\n" +
                                      "      |\n" +
                                      "      |\n" +
                                      "      |\n" +
                                      "=========''', '''");
                    break;
                case 2:
                    Console.WriteLine("  +---+\n" +
                                      "  |   |\n" +
                                      "  0   |\n" +
                                      "      |\n" +
                                      "      |\n" +
                                      "      |\n" +
                                      "=========''', '''");
                    break;
                case 3:
                    Console.WriteLine("  +---+\n" +
                                      "  |   |\n" +
                                      "  0   |\n" +
                                      "  |   |\n" +
                                      "      |\n" +
                                      "      |\n" +
                                      "=========''', '''");
                    break;
                case 4:
                    Console.WriteLine("  +---+\n" +
                                      "  |   |\n" +
                                      "  0   |\n" +
                                      " /|   |\n" +
                                      "      |\n" +
                                      "      |\n" +
                                      "=========''', '''");
                    break;
                case 5:
                    Console.WriteLine("  +---+\n" +
                                      "  |   |\n" +
                                      "  0   |\n" +
                                      " /|\\  |\n" +
                                      "      |\n" +
                                      "      |\n" +
                                      "=========''', '''");
                    break;
                case 6:
                    Console.WriteLine("  +---+\n" +
                                      "  |   |\n" +
                                      "  0   |\n" +
                                      " /|\\  |\n" +
                                      " /    |\n" +
                                      "      |\n" +
                                      "=========''', '''");
                    break;
                case 7:
                    Console.WriteLine("  +---+\n" +
                                      "  |   |\n" +
                                      "  0   |\n" +
                                      " /|\\  |\n" +
                                      " / \\  |\n" +
                                      "      |\n" +
                                      "=========''', '''");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        public static void GameLoop()
        {
           string word = WordEntry();
           //DrawGame(int[], word;
           //Console.WriteLine(word);
           int counter = word.Length;
           int hangmanprogress = 0;
           while (counter > 0 || hangmanprogress > 6)
           {
               
               Console.WriteLine("Enter your guess: ");
               char guess = Convert.ToChar(Console.ReadLine());
               int[] guessPositions = CheckGuess(guess, word);
               int amount = 0;
               for (int i = 0; i < (word.Length); i++)
               {
                   if (guessPositions[i] == 1)
                   {
                       amount++;
                   }
                   //Console.WriteLine(guessPositions[i]);
               }
               counter -= amount;
               if (amount > 0)
               {
                   Console.WriteLine("Good job you guessed correct!!!");
               }
               else
               {
                   Console.WriteLine("Unlucky you failiure!!!!");
                   hangmanprogress++;
               }

               //DrawGame(guessPositions,word);
               Console.WriteLine(Convert.ToString(CheckGuess(guess, word)));
               /*if (Contains(guess, word) == -1)
               {
                   Console.WriteLine("You guessed the "+(ret+1)+" Character correctly");
               }
               else if (ret == -1)
               {
                   Console.WriteLine("You guessed incorrectly");
               }
               */
           }
        }

        public static void Main(string[] args)
        {
            // Ben           - enter the words and allow user to choose
            // Ollie TJ      - function that loops through the word to see where letters are
            // Ollie Blom    - Main while loop
            string letterChoice = "n";
            string wordActual = "Beginning";
            GameLoop();
            /* int ret;
            ret = Contains(letterChoice, wordActual);
            if (ret != -1)
            {
                Console.WriteLine("You guessed the "+(ret+1)+" Character correctly");
            }
            else if (ret == -1)
            {
                Console.WriteLine("You guessed incorrectly");
            }
            */
        }
    }
}