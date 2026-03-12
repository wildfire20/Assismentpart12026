using System;
using System.Threading;

namespace Cyberpunk
{
    public class ChatbotUI
    {
        // This method handles Question 2: ASCII Logo and Question 6: Colors
        public void DisplayWelcomeScreen()
        {
            Console.Clear(); // Clears the screen for a fresh start
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Raw string literal for easy ASCII art
            string logo = @"
   _____       __               ____        __ 
  / ___/__  __/ /_  ___  ____  / __ )____  / /_
  \__ \/ / / / __ \/ _ \/ __ \/ __  / __ \/ __/
 ___/ / /_/ / /_/ /  __/ / / / /_/ / /_/ / /_  
/____/\__,_/_.___/\___/_/ /_/_____/\____/\__/  
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

        // This method handles Question 6: Typing effect
        public void TypeMessage(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30); // Pauses for 30 milliseconds between each letter
            }
            Console.WriteLine(); // Drops to the next line when finished
            Console.ResetColor();
        }
    }
}
