using System;
using System.IO;
using System.Linq;

namespace Lab03SystemsIO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = UserInterface();
            }
        }
        public static bool UserInterface()
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
                string allWords = File.ReadAllText("../../../myFile.txt");
                Console.WriteLine("List of of players: \n\n" + allWords + "\n\nPress'ENTER'to return to Main Menu");
                string userInput3 = Console.ReadLine();
                viewNames("../../../myFile.txt", userInput3);
                return true;
            }
            else if (userInput == "3")
            {
                Console.Clear();
                Console.WriteLine(" Type the first name of the basketball player you would like to add.");
                string userAnswer = "\n" + Console.ReadLine();
                addName("../../../myFile.txt", userAnswer);
                return true;
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Which name would you like to remove?");
                string removedName = Console.ReadLine();
                removeName("../../../myFile.txt", removedName);
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
        /// method randomly selects a name from the file, then gives placeholders the length of the random name selected.
        /// if user enters the correct character that character will replace the placeholder with that correct input. If user input 
        /// does not match the random name selected nothing changes.
        /// </summary>
        public static void playGame()
        {
            Console.Clear();
            Console.Write(" Try to guess the first name of this baseketball player, one character at a time. Press 'ENTER' to begin.");
            Console.ReadLine();
            Random randomName = new Random();
            string[] allNames = File.ReadAllLines("../../../myFile.txt");
            int randomNamechosen = randomName.Next(allNames.Length);
            string nameSelected = allNames[randomNamechosen];
            string[] placeHolders = new string[nameSelected.Length];
            bool wonGame = false;

            for (int i = 0; i < placeHolders.Length; i++)
            {
                placeHolders[i] = "_";
            }
            while (wonGame == false)
            {

                string userInput = Console.ReadLine();

                Console.WriteLine($"You guessed '{userInput}'");

                for (int i = 0; i < placeHolders.Length; i++)
                {
                    // info regarding comparing strings from: https://docs.microsoft.com/en-us/dotnet/csharp/how-to/compare-strings

                    bool result = placeHolders[i].Equals(userInput);
                    if (result)
                    {
                        placeHolders[i] = userInput;
                    }
                }

                if (!nameSelected.Contains(userInput))
                {
                    Console.WriteLine($"Sorry this player does NOT have a '{userInput}' in their first name");
                }



                if (nameSelected.Contains(userInput))
                {
                    Console.WriteLine($"This player does have a '{userInput}' in their name");

                    for (int i = 0; i < nameSelected.Length; i++)
                    {
                        if (nameSelected[i].ToString() == userInput)
                        {
                            placeHolders[i] = userInput;
                        }
                    }
                }



                foreach (string letter in placeHolders)
                {
                    Console.WriteLine(letter);
                }



                if (!placeHolders.Contains("_"))
                {
                    wonGame = true;
                    Console.WriteLine("\nCongratulations you guessed the correct player!");
                    Console.WriteLine("Press 1 to play another game");
                    Console.WriteLine("Press 'ENTER' to return to the main menu");
                    string userResponse2 = Console.ReadLine();
                    if (userResponse2 == "1")
                    {
                        playGame();
                    }
                    else
                    {
                        exitGame();
                    }

                }

            }

        }


        /// <summary>
        /// method returns user to main menu screen
        /// </summary>
        public static void exitGame()
        {

         UserInterface();

        }


        /// <summary>
        /// allows user to view all the words in the file. User can press ENTER and it will automatically return them to the main menu.
        /// </summary>
        public static string viewNames(string path, string userInput3)
        {
            string allWords = File.ReadAllText("../../../myFile.txt");
            return userInput3;
        }


        /// <summary>
        /// method used for remove method. The console write line will need to be different for the view method that im 
        /// calling in the remove method so I created another view names method.
        /// </summary>
        /// <param name="path"></param>
        public static void viewNames2(string path)
        {
            Console.Clear();
            string allWords = File.ReadAllText(path);
            Console.WriteLine("List of of players: \n\n" + allWords + "\n");
        }

        /// <summary>
        /// allows user to add their own words to the file/ game. That new word will now be part of the game.
        /// I also call the viewWords method so that way the user is able to verifiy that the word they added is actually on the list.
        /// </summary>
        public static string addName(string path, string userAnswer)
        {
           
            string[] namesAdded = new string[] { userAnswer };
            File.AppendAllLines(path, namesAdded);
            Console.WriteLine($" {userAnswer} was sucessfully added to the list. Press 'ENTER' to return to the main menu.");
            Console.ReadLine();
            return userAnswer;
        }


        /// <summary>
        /// this method first shows the user the list again then, allows the user to remove a word from the list.
        /// by calling the viewNames2 method this allows the user to not have to remember if the word they want to remove is in the list or not.
        /// </summary>
        public static void removeName(string path, string removedName)
        {


        }
        


       
    }
}
