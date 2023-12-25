using System;
using System.Threading;

namespace GameFunctions
{
    internal static class TitleScreen
    {
        #region Title Screen
        /// <summary>
        /// Dsiplays the sequence for the Game introduction
        /// </summary>
        internal static void GameTitleScreen()
        { 
            DisplayLoading();
            DisplayTitle();
            WaitForStart();
        }
        #endregion

        #region Loading Simulation
        /// <summary>
        /// Simulates a loading process for the games
        /// </summary>
        private static void DisplayLoading()
        {
            Console.Write("Loading game");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000); 
            Console.Write(".");
            Thread.Sleep(1000); 
            Console.Write(".");
            Console.Clear();
        }
        #endregion

        #region Display Title Screen
        /// <summary>
        /// Displays the game title made in ASCII, 
        /// made with this very cool webpage: https://ascii.today
        /// </summary>
        private static void DisplayTitle()
        {
            Console.WriteLine(@"  
                         _____ _            __  __           _                    
                        |_   _| |__   ___  |  \/  | __ _ ___| |_ ___ _ __         
                          | | | '_ \ / _ \ | |\/| |/ _` / __| __/ _ \ '__|        
                          | | | | | |  __/ | |  | | (_| \__ \ ||  __/ |           
                          |_| |_|_|_|\___| |_|  |_|\__,_|___/\__\___|_|           
                                 ___  / _|                                               
                                / _ \| |_                                                
                               | (_) |  _|                                               
                         ____   \___/|_|               _____                      
                        |  _ \  ___   ___  _ __ ___   |_   _|____      _____ _ __ 
                        | | | |/ _ \ / _ \| '_ ` _ \    | |/ _ \ \ /\ / / _ \ '__|
                        | |_| | (_) | (_) | | | | | |   | | (_) \ V  V /  __/ |   
                        |____/ \___/ \___/|_| |_| |_|   |_|\___/ \_/\_/ \___|_|");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t-Game by RAMorales-01");
            Console.WriteLine("\n"); 
            Thread.Sleep(1000);
            Console.WriteLine("\t\t\t\t\tPress ENTER to start");
            Console.ReadKey();
        }
        #endregion

        #region View Instructions ?
        /// <summary>
        /// Gives the player the choice to view the game instructions
        /// or proceed with directly to the game
        /// </summary>
        private static void WaitForStart()
        {
             do
            {
                Console.Clear();
                Console.WriteLine("View Instructions? Y/N: ");
                var readInput = Console.ReadLine()?.ToUpper();
                if(string.IsNullOrEmpty(readInput))
                {
                    Console.WriteLine("Input cannot be empty or void, press KEY to try again");
                    Console.ReadKey();
                }
                else if(readInput.Equals("N") || readInput.Equals("NO"))
                {
                    break;
                }
                else if(readInput.Equals("Y") || readInput.Equals("YES"))
                {
                    GameInstructions();
                    break;
                } 
                else
                {
                    Console.WriteLine("Input not valid, press KEY to try again");
                    Console.ReadKey();
                }
            }while(true);
        }
        #endregion

        #region Display the game instructions
        /// <summary>
        /// Displays the instructions to the player
        /// </summary>
        private static void GameInstructions()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the game instructions\n");
            Thread.Sleep(1000);
            Console.WriteLine("The game consist of a simple turn base combat, the player starts");
            Console.WriteLine("with basic equipment and some gold to buy new equipment.\n");
            Thread.Sleep(1000);
            Console.WriteLine("The player must traverse each floor of the tower and survive five rounds, before be able to");
            Console.WriteLine("to move to the next floor.\n");
            Thread.Sleep(1000);
            Console.WriteLine("The player cannot heal during the five rounds, only AFTER surviving the five rounds and the only");
            Console.WriteLine("by buying the healing potions on the shop with money earned in each battle.\n");
            Thread.Sleep(1000);
            Console.WriteLine("After clearing 2 floors the player must defeat a boss to proceed to the next set of floors, if the player dies");
            Console.WriteLine("before defeating the boss, it will lose half of collected gold and all the equipment goes back to the starting equipment.");
        }
        #endregion
    }
}