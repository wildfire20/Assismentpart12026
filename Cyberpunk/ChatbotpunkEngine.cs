using System;

namespace Cyberpunk
{
    public class ChatbotpunkEngine
    {
        // This method takes what the user typed and figures out how to answer
        public string GetResponse(string input)
        {
            // --- QUESTION 5: Input Validation ---
            // Detect invalid inputs (empty entries) gracefully
            if (string.IsNullOrWhiteSpace(input))
            {
                return "I didn't quite understand that. Could you rephrase?";
            }

            // Convert input to lowercase so it's easier to search for keywords fdegddvt ghd dtrd gwfdtvd fyd ydf
            string lowerInput = input.ToLower();

            // --- QUESTION 4: Basic User Interaction ---
            if (lowerInput.Contains("how are you"))
            {
                return "I'm functioning perfectly! Ready to talk about cybersecurity.";
            }
            else if (lowerInput.Contains("purpose") || lowerInput.Contains("what are you"))
            {
                return "My purpose is to educate users on online safety and simulate cyber threats.";
            }
            else if (lowerInput.Contains("what can i ask"))
            {
                return "You can ask me about password safety, phishing, or safe browsing.";
            }

            // --- QUESTION 4: Cybersecurity Topics ---
            else if (lowerInput.Contains("password"))
            {
                return "Password Safety: Always use a strong, unique password (at least 12 characters). Consider using a password manager and enabling Two-Factor Authentication (2FA).";
            }
            else if (lowerInput.Contains("phish") || lowerInput.Contains("email"))
            {
                return "Phishing: Be wary of unsolicited emails asking for personal info. Always check the sender's actual email address and never click suspicious links.";
            }
            else if (lowerInput.Contains("browsing") || lowerInput.Contains("safe"))
            {
                return "Safe Browsing: Look for 'https://' in the URL and a padlock icon. Avoid entering sensitive info on public Wi-Fi networks.";
            }

            // --- QUESTION 5: Default Response for unsupported queries ---
            else
            {
                return "I didn't quite understand that. Could you rephrase? (Try asking about passwords, phishing, or safe browsing).";
            }
        }
    }
}
