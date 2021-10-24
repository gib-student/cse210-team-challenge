using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    public class Director
    {
        private bool        _keepPlaying = true;
        private Board       _board = new Board();
        private UserService _userService = new UserService();
        private Roster      _roster = new Roster();
        private Hint        _hint = new Hint();
        private string      _guess;

        /// Set up the game and run until game is finished
        public void StartGame()
        {
            PrepareGame();

            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutPuts();
            }
        }
        /// Set up the game by getting player names
        private void PrepareGame()
        {
            for (int i = 0; i < 2; i++)
            {
                string prompt = $"Enter a name for player {i + 1}: ";
                string name = _userService.GetStringInput(prompt);

                // Add players to the roster and create a board for them
                _roster.AddPlayer(name);
                _board.AddPlayer(name);
            }
        }
        /// Get any inputs from the user
        private void GetInputs()
        {
            // Display board
            string board = _board.ToString();
            _userService.DisplayText(board);

            // Get next player move
            string currentPlayer = _roster.GetCurrentPlayer();
            _userService.DisplayText($"{currentPlayer}'s turn:");
            _guess = _userService.GetStringInput("What is your guess? ");
        }

        /// Update Actors
        private void DoUpdates()
        {
            string currentPlayer = _roster.GetCurrentPlayer();

            // Get the hint
            string hint = _hint.GetHint(
                _board.GetSecretNum(currentPlayer), _guess);

            // Make changes to the board
            _board.Apply(currentPlayer, _guess, hint);
        }

        /// Display the updated state of the Game to the User
        private void DoOutPuts()
        {
            // Check if game is over
            if (_board.GameOver())
            {
                // Display a game-end message
                string winningPlayer = _roster.GetCurrentPlayer();
                _userService.DisplayText($"{winningPlayer} won!");
                _keepPlaying = false;
            }
            else
            {
                // Move to the Next Player
                _roster.AdvanceNextPlayer();
            }
        }
    }
}
