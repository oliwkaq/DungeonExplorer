using System;
using System.Media;
using System.Runtime.Remoting.Channels;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;

        public Game()
        {
            // Initialize the game with one room and one player
            currentRoom = new Room("A small dimly lit room with cobbled walls, there is a singular desk to the side with a small vial on it and a single door that will let you exit");
            Console.WriteLine("Please Enter your name, ");
            string player_name = Console.ReadLine();
            player = new Player(player_name, 20);
        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = true;
            while (playing)
            {
                // Code your playing logic here
                bool room1 = true;
                bool collected_item = false;
                Console.WriteLine("You are in a room, what would you like to do? " +
                    "Please type in one of the actions from the following list: " +
                    "Check Name: Checks your character's name " +
                    "Check Health: Checks your character's health " +
                    "Look Around: Check your surroundings for a description of the room ");
                while (room1)
                {
                    bool correct_action = false;
                    while (correct_action == false)
                    {
                        string action = Console.ReadLine();
                        if (action == "Check Name")
                        {
                            Console.WriteLine(player.Name);
                            correct_action = true;
                        }
                        else if (action == "Check Health")
                        {
                            Console.WriteLine(player.Health);
                            correct_action = true;
                        }
                        else if (action == "Look Around")
                        {
                            string description = currentRoom.GetDescription();
                            Console.WriteLine(description);
                            Console.WriteLine("You can now use the following commands on top of prior ones: " +
                            "Pick Up Item: Picks up an item in a room " +
                            "Use Door: Your character will exit the door ending the game ");
                            correct_action = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid action");
                        }
                    }  
                    while (room1)
                    {
                        bool correct_action2 = false;
                        while (correct_action2 == false)
                        {
                            string action2 = Console.ReadLine();
                            if (action2 == "Check Name")
                            {
                                Console.WriteLine(player.Name);
                                correct_action2 = true;
                            }
                            else if (action2 == "Check Health")
                            {
                                Console.WriteLine(player.Health);
                                correct_action2 = true;
                            }
                            else if (action2 == "Look Around")
                            {
                                string description = currentRoom.GetDescription();
                                Console.WriteLine(description);
                                correct_action2 = true;
                            }
                            else if (action2 == "Pick Up Item")
                            {
                                if (collected_item == false)
                                {
                                    player.PickUpItem("Vial");
                                    Console.WriteLine("You have picked up the vial");
                                    collected_item = true;
                                }
                                else
                                {
                                    Console.WriteLine("You have already picked up the vial");
                                }
                                correct_action2 = true;
                            }
                            else if (action2 == "Use Door")
                            {
                                Console.WriteLine("You have exited the room. The Game is now over.");
                                room1 = false;
                                playing = false;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid action");
                            }
                        }
                    }
                }
            }
        }
    }
}
