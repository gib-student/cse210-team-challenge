using System;

namespace _06_mastermind
{
    public class UserService
    {
        /// gets player name, returns player name
        public string GetStringInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        
        /// displays board
        public void DisplayText(String board)
        {
            Console.WriteLine(board);
        }
    }
}
