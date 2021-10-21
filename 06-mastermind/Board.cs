using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _06_mastermind
{
    public class Board
    {
        private IDictionary<string,string> _board;
        
        /// Make a new game board.
        /// Board variable design: dictionary.
        private Board(string name1, string name2)
        {
            _board = new Dictionary<string, string>();

            // Create the board
            // Add the player's names
            _board.Add("player1", name1);
            _board.Add("player2", name2);
            // Add random secret numbers between 1000 and 9999
            _board.Add("p1Num", RandomGenerator(1000,9999).ToString());
            _board.Add("p2Num", RandomGenerator(1000,9999).ToString());
            // Add last given move (starts out as nothing)
            _board.Add("p1Move", "----");
            _board.Add("p2Move", "----");
            // Add the starting hints (starts out as nothing)
            _board.Add("p1Hint", "****");
            _board.Add("p2Hint", "****");
        }

        /// Return a string of the board.
        public override string ToString()
        {
            string boardString="";
            // Beginning separating line
            boardString += "---------------------\n";
            // Player 1
            boardString += "Player " + _board["player1"] + ": " + 
                _board["p1Move"] + ", " + _board["p1Hint"] + "\n";
            // Player 2
            boardString += "Player " + _board["player2"] + ": " +
                _board["p2Move"] + ", " + _board["p2Hint"] + "\n";
            // Ending separating line
            boardString += "---------------------";

            return boardString;
        }

        /// Check if the game is over.
        /// Return: true for yes, false for no.
        public bool GameOver()
        {
            if ((_board["p1Num"] == _board["p1Move"]) ||
                (_board["p2Num"] == _board["p2Move"]))
            {
                return true;
            }
            // Win conditions are not satisfied, game is not over
            return false;
        }

        /// Make changes to the board.
        /// Change the player's last move and hint given to them.
        public void Apply(string name, int newNum, string newHint)
        {
            // Validate the parameters
            Debug.Assert(name == _board["player1"] || name == _board["player2"]);
            Debug.Assert(newNum <= 9999 && newNum >= 1000);
            int lettersNewHint = 0;
            foreach (char letter in newHint)
            {
                lettersNewHint++;
            }
            Debug.Assert(lettersNewHint > 0 && lettersNewHint <= 4);

            string player="";
            if (name == _board["player1"])
            {
                player = "p1";
            }
            else if (name == _board["player2"])
            {
                player = "p2";
            }
            
            // Make the edits
            // Edit last move
            _board[player + "Move"] = newNum.ToString();
            // Edit last given hint
            _board[player + "Hint"] = newHint;
        }

        /// Generate a random number between the limits provided.
        private int RandomGenerator(int lower, int upper)
        {
            Random randomNumber = new Random();

            return randomNumber.Next(lower, upper + 1);
        }
    }
}
