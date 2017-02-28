using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4ProjectLindseyLoweVirtualPet
{
    public class Monster
    {
        //Declare fields for Monster Class:
        private string monsterName;
        private string monsterColor;
        private string monsterAge;
        private string userPlayChoice;


        //Properties for Monster:
        public string MonsterName
        {
            get { return this.monsterName; }
            set { this.monsterName = value; }
        }
        public string MonsterColor
        {
            get { return this.monsterColor; }
            set { this.monsterColor = value; }
        }
        public string MonsterAge
        {
            get { return this.monsterAge; }
            set { this.monsterAge = value; }
        }



        //Methods for Monster:
        #region

        public void Speakto() //random choices for speech outputs
        {
            Console.WriteLine();
            Console.WriteLine();
            Random randomSpeak = new Random();
            string[] speakChoices = new string[] { ("Hello my name is " + monsterName + " and I like to eat garbage."), ("I think my " + monsterColor + " colored fur is awesome!"), ("I am " + monsterAge + " years old today.  My favorite flavor of birthday cake is liver and dumpster juice!") };
            Console.WriteLine((speakChoices[randomSpeak.Next(3)]));
            Console.WriteLine();

        }

        public void Feedit() //random choices for hungry outputs
        {
            Console.WriteLine();
            Console.WriteLine();
            Random randomFeed = new Random();
            string[] feedChoices = new string[] { ("I'm not hungry right now, thanks."), ("Yay!! I really like eating trash, can I have more please?"), ("RAWR!! " + monsterName + " is still very hungry!!"), (monsterName + " has a lot of food in their " + monsterColor + " colored fur.  They are snoring and seem very happy.") };
            Console.WriteLine((feedChoices[randomFeed.Next(3)]));
            Console.WriteLine();
        }

        public void Playwith() //presents options for playing with monster


        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("How should we play?  Type the number of your choice.");
            Console.WriteLine();
            string[] playchoices = new string[] { " 1: Throw the ball ", " 2: Pet my belly ", " 3: Play with a stick ", " 4: Play hide and seek" };
            foreach (string choice in playchoices)
            {
                Console.Write(choice);
                Console.WriteLine();
                Console.WriteLine();
            }

            userPlayChoice = Console.ReadLine(); //user chooses how they want to play
            #region
            bool correctSelection = false;
            while (!correctSelection)
            {

                if (userPlayChoice == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("You throw the ball, " + monsterName + " catches the ball, and then proceeds to rip it into tiny shreds.");
                    correctSelection = true;
                    Console.WriteLine();
                }
                else if (userPlayChoice == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("You pet " + monsterName + "'s " + monsterColor + " fluffy belly and get bit... \n Everyone knows you shouldn't pet a monster!");
                    correctSelection = true;
                    Console.WriteLine();
                }
                else if (userPlayChoice == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine(monsterName + " brings you a stick to throw -- \n You throw it and " + monsterName + " brings back a mouthful of trash and bones instead.");
                    correctSelection = true;
                    Console.WriteLine();
                }
                else if (userPlayChoice == "4")
                {
                    Console.WriteLine();
                    Console.WriteLine("You start counting to ten and " + monsterName + " runs off to hide...");
                    {
                        for (int countdown = 1; countdown <= 10; countdown++)

                        {
                            Console.WriteLine(countdown);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.WriteLine("After you reach 10, you look down and realize " + monsterName + " went nowhere and has fallen asleep on the ground next to you.");
                        correctSelection = true;
                        Console.WriteLine();
                    }
                }
                else //checks for user input validation
                {
                    Console.WriteLine("You did not enter a valid choice, please type 1-4 as an answer:");
                    userPlayChoice = Console.ReadLine();
                    correctSelection = false;
                }

            }//end of play choices 
            #endregion 

        }//end of playWith
        #endregion
    } //end of Monster

} // end of namespace

