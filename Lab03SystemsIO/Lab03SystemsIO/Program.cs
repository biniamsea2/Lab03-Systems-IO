using System;

namespace Lab03SystemsIO
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine(" \n                                          Welcome To Biniam's guessing game \n");
            Console.WriteLine("                                             Please select an option below \n\n");
            Console.WriteLine("                                              1) Play Game\n");
            Console.WriteLine("                                              2) View Words\n");
            Console.WriteLine("                                              3) Add a word to the list\n");
            Console.WriteLine("                                              4) Remove a word from the list\n");
            Console.WriteLine("                                              5) EXIT ");
            string userInput = Console.ReadLine();


            if (userInput == "1")
            {
                playGame();
                return true;
            }
            else if (userInput == "2")
            {
                viewWords();
                return true;
            }
            else if (userInput == "3")
            {
                addWord();
            return true;
            }
            else if (userInput == "4")
            {
                removeWord();
                    return true;
            }
            else if (userInput == "5")
            {
                return false;
            }
            else
            {
                return false;
            }


        }


        /// <summary>
        /// method allows user to play game, also calls the exit method to allow user to exit game,
        /// and the play again method allows user to play the game again.
        /// </summary>
        private static void playGame()
        {
            playAgain();
            exitGame();

        }

        /// <summary>
        /// if user clicks "1" it will call the new game method, allowing them to play a new game.
        /// </summary>
        private static void playAgain()
        {
            Console.WriteLine("Press 1) To play a new game");
            string userAnswer = Console.ReadLine();
            if (userAnswer == "1")
            {
                playGame();
            }
        }

        private static void exitGame()
        {
            Console.WriteLine("Press 2) To exit game");
            string userAnswer = Console.ReadLine();
            if (userAnswer == "2")
            {
                MainMenu();
            }

        }



        private static void viewWords()
        {

        }




        private static void addWord()
        {

        }



        private static void removeWord()
        {

        }



       
    }
}
