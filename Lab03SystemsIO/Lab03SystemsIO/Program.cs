using System;
using System.IO;

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
            Console.WriteLine(" Welcome To Biniam's Basketball Guessing Game \n");
            Console.WriteLine(" Please select an option below \n\n");
            Console.WriteLine(" 1) Play Game\n");
            Console.WriteLine(" 2) View Names\n");
            Console.WriteLine(" 3) Add a name to the list\n");
            Console.WriteLine(" 4) Remove a name from the list\n");
            Console.WriteLine(" 5) EXIT ");
            string userInput = Console.ReadLine();
            
            if (userInput == "1")
            {
                playGame();
                return true;
            }
            else if (userInput == "2")
            {
                viewNames("../../../myFile.txt");
                return true;
            }
            else if (userInput == "3")
            {
                addName("../../../myFile.txt");
            return true;
            }
            else if (userInput == "4")
            {
                removeName();
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
            Console.WriteLine("Try to guess the first name of this baseketball player, one character at a time.");
        }

        /// <summary>
        /// if user clicks "1" it will call the new game method, allowing them to play a new game.
        /// if the user clicks 2 it calls exitGame method returning user to the main menu
        /// </summary>
        private static void playAgain()
        {
            Console.Clear();
            Console.WriteLine("Press 1) To play a new game");
            Console.WriteLine("Press 2) EXIT");
            string userAnswer = Console.ReadLine();
            if (userAnswer == "1")
            {
                playGame();
            }
            else
            {
                exitGame();
            }
        }
        /// <summary>
        /// method returns user to main menu screen
        /// </summary>
        private static void exitGame()
        {

         MainMenu();

        }


        /// <summary>
        /// allows user to view all the words in the file. User can press ENTER and it will automatically return them to the main menu.
        /// </summary>
        private static void viewNames(string path)
        {
            Console.Clear();
            string allWords = File.ReadAllText(path);
            Console.WriteLine("List of of players: \n\n" + allWords + "\n\nPress'ENTER'to return to Main Menu");
            string userInput = Console.ReadLine();


        }


        /// <summary>
        /// method used for remove method. The console write line will need to be different for the view method that im 
        /// calling in the remove method so I created another view names method.
        /// </summary>
        /// <param name="path"></param>
        private static void viewNames2(string path)
        {
            Console.Clear();
            string allWords = File.ReadAllText(path);
            Console.WriteLine("List of of players: \n\n" + allWords + "\n");

        }

        /// <summary>
        /// allows user to add their own words to the file/ game. That new word will now be part of the game.
        /// I also call the viewWords method so that way the user is able to verifiy that the word they added is actually on the list.
        /// </summary>
        private static void addName(string path)
        {
            Console.Clear();
            Console.WriteLine(" Type the first name of the basketball player you would like to add.");
            string userInput = "\n" + Console.ReadLine() + " (name added by user)";
            File.AppendAllText(path, userInput);
            Console.WriteLine($"Your input was sucessfully added to the list. Press 'ENTER' to return to the main menu.");
            Console.ReadLine();
        }


        /// <summary>
        /// this method first shows the user the list again then, allows the user to remove a word from the list.
        /// by calling the viewNames2 method this allows the user to not have to remember if the word they want to remove is in the list or not.
        /// </summary>
        private static void removeName()
        {
            viewNames2("../../../myFile.txt");
            Console.WriteLine("Which name would you like to remove?");
            string userInput = Console.ReadLine();

        }



       
    }
}
