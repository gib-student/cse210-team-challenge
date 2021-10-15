using System;

namespace _05_jumper
{
    /// Interact with the user, displaying all outputs and getting all inputs
    /// from them.
    public class UserService
    {
        /// Display the current state of the parachute.
        /// Use the list of bools "_parachute" as an indicator of which parts 
        /// of the parachute to show
        public void DisplayParachute()
        {
            throw new NotImplementedException();
        }

        /// Get the letter the player wants to guess
        public string PromptLetter()
        {
            Console.Write("Guess a letter [a-z]: ");
            return Console.ReadLine();
        }

        /// Show an "invalid input" message
        public void ShowBadInputMessage()
        {
            Console.WriteLine("Please enter a letter a-z.");
        }
    }
}