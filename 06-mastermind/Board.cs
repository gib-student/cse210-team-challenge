using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _06_mastermind
{
    public class Board
    {
        Dictionary<string, string> _board = new Dictionary<string, string>();
        private int _numPlayers=0;
        private bool _debug = false; // Turn true to activate debug code

        /// Make a new game board.
        /// Board variable design: dictionary.
        public void AddPlayer(string name)
        {
            Debug.Assert(_numPlayers <= 2 );

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
            _board.Add(player + "Num", RandomGenerator(1000,9999));
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
            boardString += "Player " + _board["p1"] + ":\t" + 
                _board["p1Move"] + ", " + _board["p1Hint"] + "\n";
            // Player 2
            boardString += "Player " + _board["p2"] + ":\t" +
                _board["p2Move"] + ", " + _board["p2Hint"] + "\n";
            // Ending separating line
            boardString += "---------------------";

            if (_debug){
                Console.WriteLine(boardString);
            }

            return boardString;
        }

        /// Return the secret number of the given player.
        public string GetSecretNum(string playerName)
        {
            string player = WhichPlayer(playerName);
            return _board[player + "Num"];

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
        public void Apply(string name, string move, string newHint)
        {
            // Validate the parameters
            Debug.Assert(name == _board["p1"] || name == _board["p2"]);
            Debug.Assert(int.Parse(move) <= 9999 && int.Parse(move) >= 1000);
            int lettersNewHint = 0;
            foreach (char letter in newHint)
            {
                lettersNewHint++;
            }
            if (_debug){
            Console.WriteLine($"\tBoard: lettersNewHint: {lettersNewHint}");
            Console.WriteLine($"\tBoard: newHint: {newHint}");
            Console.WriteLine($"\tBoard: move: {move}");
            }
            Debug.Assert(lettersNewHint > 0 && lettersNewHint <= 4);

            // Check whose player's board we are editing
            string player = WhichPlayer(name);
            
            // Make the edits
            // Edit last move
            _board[player + "Move"] = move;
            // Edit last given hint
            _board[player + "Hint"] = newHint;
        }

        /// Generate a random number between the limits provided.
        private string RandomGenerator(int lower, int upper)
        {
            Debug.Assert(lower >= 0 && upper >= 0);

            Random randomNumber = new Random();
            string randomNumbers="";
            
            randomNumbers = randomNumber.Next(lower, upper + 1).ToString();

            return randomNumbers;
        }

        /// Find out which player is being referenced
        private string WhichPlayer(string name)
        {
            Debug.Assert(name == _board["p1"] ||
                name == _board["p2"]);
            
            if (name == _board["p1"])
            {
                return "p1";
            }
            else if (name == _board["p2"])
            {
                return "p2";
            }
            return "ERROR";
        }
    }
}
