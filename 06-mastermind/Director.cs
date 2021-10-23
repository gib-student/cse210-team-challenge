using System;

namespace _06_mastermind
{
    public class Director
    {
        private bool _keepPlaying = true;
        private Board _board = new Board();
        private UserService _userService = new UserService();
        private Roster _roster = new Roster();
        private Hint _hint = new Hint();
        private int _guess;
        
        //Set up the game and run until game is finished
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
        //Set up the game by getting player names
        private void PrepareGame()
        {
            for (int i = 0; i < 2; i++)
            {
                string prompt = $"Enter a name for player {i + 1}: ";
                string name = _userService.GetStringInput(prompt);

                //Add players to the roster and board
                _roster.AddPlayer(name);
                _board.AddPlayer(name);
            }
        }
        //Get any inputs from the user
        private void GetInputs()
        {
            //Display board
            string board = _board.ToString();
            _userService.DisplayText(board);

            //Get next player move
            Roster currentPlayer = _roster.GetCurrentPlayer();
            _userService.DisplayText($"{currentPlayer.GetName()}'s turn:");
            _guess = _userService.GetNumberInput("What is your guess? ");

            //Set the Hint for  Current Player Guess
            Hint hint = new hint(_guess);
            currentPlayer.SetMove(hint);
        }

        //Update Actors
        private void DoUpdates()
        {   
            //Apply the move from Current Player to the Board
            string currentPlayer = _roster.GetCurrentPlayer();
            string hint = _hint.GetHint();
            _board.Apply(currentPlayer, _guess, hint);
        }
        
        //Display the updated state of the Game to the User
        private void DoOutPuts()
        {
            //Find out if Game is Over
            if (_board.GameOver())
            {
                Roster winningPlayer = _roster.GetCurrentPlayer();
                string name = winningPlayer.GetName();
                _userService.DisplayText($"{name} won!");
                _keepPlaying = false;
            }
            //Move to the Next Player
            _roster.AdvanceNextPlayer();
        }
    }
}
