using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4ProjectLindseyLoweVirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster newMonster = new Monster();


            Console.WriteLine("What is the name of your monster?");
            newMonster.MonsterName = Console.ReadLine().ToLower();
            Console.WriteLine("What color will your monster be?");
            newMonster.MonsterColor = Console.ReadLine().ToLower();
            
             int monsterAge; //checks for errors
            {
                Console.WriteLine("How many years old is your monster?");

                while (!int.TryParse(Console.ReadLine(), out monsterAge))
                    Console.WriteLine("Not a valid entry, please enter in an integer:");
            }
            
            

            
            //main menu:

            bool exit = false;
            while (!exit) //sets up 'quit' option in menu
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("What would you like to do with your monster? \n Type \"speak\" to have your monster talk to you. \n Type \"feed\" to give your monster something to eat. \n Type \"play\" to interact with your monster. \n Type \"exit\" to quit from this menu.");
                string userChoice = Console.ReadLine().ToLower();

                if (userChoice == "speak")
                {
                    newMonster.Speakto();
                    Console.WriteLine("Push enter to do something else!");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (userChoice == "feed")
                {
                    newMonster.Feedit();
                    Console.WriteLine("Push enter to do something else!");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (userChoice == "play")
                {
                    newMonster.Playwith();
                    Console.WriteLine("Push enter to do something else!");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (userChoice == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                else
                {
                    Console.WriteLine("Please enter \"speak\", \"feed\", or \"play\"."); //validate user making a choice from the menu

                }

            }// end of while loop

        }// end of Main
    }
}
