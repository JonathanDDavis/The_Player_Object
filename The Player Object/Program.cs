using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace The_Player_Object
{
    class player
    {
        public static string Name { get; set; }
        public static int Age { get; set; }

        public static string Greeting()
        {
            Console.WriteLine("Hello player what is your name?");
            Name = Console.ReadLine();
            Console.WriteLine("Now how old are you");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello player, Your name is {0} and you are {1} years old.", Name, Age);

            string stay = "no";
            while (stay == "no")
            {
                Console.WriteLine("Are you ready to play?");
                string answer = Console.ReadLine();
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("Okay get ready to play!");
                    stay = "yes";
                }
                else if (answer == "no")
                    Console.WriteLine("Okay, just tell me when you are ready to play.");
                else
                    Console.WriteLine("Sorry that is an invalid input.");
            }

            return stay;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            player.Greeting();

            string newGame = "yes";
            while (newGame == "yes")
            {
                Random kingsLocation = new Random();
                List<string> location = new List<string> { "north", "south", "east", "west" };
                int index = kingsLocation.Next(location.Count);
                //Comment this out before the end
                Console.WriteLine(location[index]);

                Console.WriteLine(
                    "The king as summoned you to the castle. When you get to the castle the guards take you to the throne room." +
                    " When you get in there the king says it is time to play a game. He disappears and you are supposed to find him.");
                Console.WriteLine(
                    "You look around and you can see 1 door on each wall. There is one to the North, South, East, and West. Which door would you want to go too.");
                string doorRoom = Console.ReadLine();
                string message = " ";
                if (doorRoom == "north")
                {
                    message = "You found the treasure room.";
                    if (location[index] == doorRoom)
                        message = message + " You found the king.";
                    else
                        message = message + " The king was not there.";
                }

                else if (doorRoom == "south")
                {
                    message = "You walked into a storage room";
                    if (location[index] == doorRoom)
                        message = message + " You found the king.";
                    else
                        message = message + " The king was not there.";
                }

                else if (doorRoom == "east")
                {
                    message = "You walked bedroom.";
                    if (location[index] == doorRoom)
                        message = message + " You found the king.";
                    else
                        message = message + " The king was not there.";
                }

                else if (doorRoom == "west")
                {
                    message = "You walked into a kitchen.";
                    if (location[index] == doorRoom)
                        message = message + " You found the king.";
                    else
                        message = message + " The king was not there.";
                }

                else
                    message = "Sorry, I do not understand you.";

                Console.WriteLine(message);
                Console.WriteLine("Thank you for playing my game. Do you want to play again?");

                string validChoose = "no";
                while (validChoose == "no")
                {
                    string endGame = Console.ReadLine();
                    if (endGame == "no")
                    {
                        validChoose = "yes";
                        newGame = "no";
                    }

                    else if (endGame == "yes")
                    {
                        validChoose = "yes";
                        Console.WriteLine("Okay.");
                    }

                    else
                        Console.WriteLine("Sorry that is not an invalid answer.");
                }
            }
        }
    }
}
