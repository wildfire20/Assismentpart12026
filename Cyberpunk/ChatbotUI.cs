using System;
using System.Threading;

namespace Cyberpunk
{
    public class ChatbotUI
    {
        // This method handles THE ASCII Logo and Question 
        public void DisplayWelcomeScreen()
        {
            Console.Clear(); // Clears the screen for a fresh start
            Console.ForegroundColor = ConsoleColor.Cyan;

            //ASCII art
            string logo = @"
  ____      _                               _    ____   ___ _____ 
 / ___|   _| |__   ___ _ __ _ __  _   _ _ __ | | _| __ ) / _ \_   _|
| |  | | | | '_ \ / _ \ '__| '_ \| | | | '_ \| |/ /  _ \| | | || |  
| |__| |_| | |_) |  __/ |  | |_) | |_| | | | |   <| |_) | |_| || |  
 \____\__, |_.__/ \___|_|  | .__/ \__,_|_| |_|_|\_\____/ \___/ |_|  
      |___/                |_|                                      
            ";

            Console.WriteLine(logo);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==================================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    [ SECURE CONNECTION ESTABLISHED ]");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==================================================\n");
            Console.ResetColor();
        }

        // This method handles Typing effect
        public void TypeMessage(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30); // Pauses for 30 ms 
            }
            Console.WriteLine(); // Drops to the next line when finished
            Console.ResetColor();
        }
    }
}
