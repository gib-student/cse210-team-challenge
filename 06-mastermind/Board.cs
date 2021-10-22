using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _06_mastermind
{
    public class Board
    {
        private IDictionary<string,string> _board;
        private int _numPlayers=0;
        private bool _debug = false; // Turn true to activate debug code
        
        /// Make a new game board.
        /// Board variable design: dictionary.
        public void AddPlayer(string name)
        {
            if (_debug){
                Debug.Assert(_numPlayers <= 2 );
            }

            // Make note if this is player 1 or 2
            string player="";
            if (_numPlayers == 0)
            {
                player = "p1";
            }
            else if (_numPlayers == 1)
            {
                player = "p2";
            }

            // Create the board
            // Add player's name
            _board.Add(player, name);
            // Add a random secret number between the two parameters
            _board.Add(player + "Num", RandomGenerator(1000,9999).ToString());
            // Add last given move (starts out as nothing)
            _board.Add(player + "Move", "----");
            //Add the starting hint (starts out as nothing)
            _board.Add(player + "Hint", "****");

            // Make note that we just made a new player
            _numPlayers++;

            // Debug
            if (_debug){
                Console.WriteLine($"Player's name: " + _board[player]);
                Console.WriteLine($"Player's secret number: " + _board[player + "Num"]);
                Console.WriteLine($"Player's last move: " + _board[player + "Move"]);
                Console.WriteLine($"Player's last hint: " + _board[player + "Hint"]);
            }

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

            if (_debug){
                Console.WriteLine(boardString);
            }

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
            if (_debug){
            // Validate the parameters
            Debug.Assert(name == _board["p1"] || name == _board["p2"]);
            Debug.Assert(newNum <= 9999 && newNum >= 1000);
            int lettersNewHint = 0;
            foreach (char letter in newHint)
            {
                lettersNewHint++;
            }
            Debug.Assert(lettersNewHint > 0 && lettersNewHint <= 4);
            }

            // Check whose player's board we are editing
            string player="";
            if (name == _board["p1"])
            {
                player = "p1";
            }
            else if (name == _board["p2"])
            {
                player = "p2";
            }
            
            // Make the edits
            // Edit last move
            _board[player + "Move"] = newNum.ToString();
            // Edit last given hint
            _board[player + "Hint"] = newHint;

            // Debug
            if (_debug){
                Console.WriteLine($"Player's name: " + _board[player]);
                Console.WriteLine($"Player's secret number: " + _board[player + "Num"]);
                Console.WriteLine($"Player's last move: " + _board[player + "Move"]);
                Console.WriteLine($"Player's last hint: " + _board[player + "Hint"]);
            }
        }

        /// Generate a random number between the limits provided.
        private int RandomGenerator(int lower, int upper)
        {
            Random randomNumber = new Random();

            return randomNumber.Next(lower, upper + 1);
        }
    }
}
