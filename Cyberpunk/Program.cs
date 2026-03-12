// See https://aka.ms/new-console-template for more information

using System;
using System.Media;
using Cyberpunk; // This links your Program to your ChatbotUI class

// --- QUESTION 1: VOICE GREETING ---
// We check if it is running on Windows because System.Media only works on Windows
if (OperatingSystem.IsWindows())
{
    try
    {
        // Plays the voice greeting in the background 
        SoundPlayer player = new SoundPlayer("greeting bot.wav");
        player.Play();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error playing sound: " + ex.Message);
    }
}

// Create an instance of our UI class to access the visuals
ChatbotUI ui = new ChatbotUI();

// --- QUESTION 2: IMAGE DISPLAY ---
// Show the ASCII logo and decorative borders
ui.DisplayWelcomeScreen();

// --- QUESTION 3: TEXT-BASED GREETING AND USER INTERACTION ---
// 1. Display a text-based welcome message right after the voice and ASCII art
ui.TypeMessage("Loading Cybersecurity Awareness Bot...", ConsoleColor.Yellow);
ui.TypeMessage("Hello! Welcome to the Cybersecurity Awareness Bot. I'm here to help you stay safe online.", ConsoleColor.Cyan);
Console.WriteLine(); // Adds a blank line for neat spacing

// 2. Ask the user for their name
ui.TypeMessage("To get started, please enter your name: ", ConsoleColor.White);

// Change the console color so the user's typed name stands out
Console.ForegroundColor = ConsoleColor.Cyan;
string userName = Console.ReadLine(); // Reads what the user types and saves it
Console.ResetColor();

Console.WriteLine(); // Adds another blank line for neatness

// 3. Personalise the response using the name they just typed
ui.TypeMessage($"Connection secured. It is great to meet you, {userName}!", ConsoleColor.Green);
ui.TypeMessage("What would you like to learn about today?", ConsoleColor.White);

// Bring in our new brain class
ChatbotpunkEngine engine = new ChatbotpunkEngine();

ui.TypeMessage("Type 'exit' or 'bye' at any time to disconnect.", ConsoleColor.DarkGray);
Console.WriteLine();

// --- THE MAIN CHAT LOOP ---
bool isChatting = true;

while (isChatting) // This loop keeps the program running until you type exit
{
    // Make the user's name yellow so it stands out
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"{userName}: ");

    // Make what the user types cyan
    Console.ForegroundColor = ConsoleColor.Cyan;
    string userInput = Console.ReadLine();
    Console.ResetColor();

    // Check if the user wants to leave
    if (userInput.ToLower() == "exit" || userInput.ToLower() == "bye")
    {
        ui.TypeMessage("CyberBot: Shutting down secure connection. Goodbye!", ConsoleColor.Green);
        isChatting = false; // This stops the while loop
    }
    else
    {
        // Send their text to the engine, get the answer back, and type it out
        string response = engine.GetResponse(userInput);
        ui.TypeMessage($"CyberBot: {response}", ConsoleColor.White);
        Console.WriteLine(); // Add a blank line for readability
    }
}