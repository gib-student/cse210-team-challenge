using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    public class Roster
    {
        private int _currentPlayerIndex = 0;
        private List<string> _players = new List<string>();
        
        /// Add the player's name to the list
        public void AddPlayer(string player)
        {
            _players.Add(player);
        }

        /// Return the name of whoever's turn it is
        public string GetCurrentPlayer()
        {
            return _players[_currentPlayerIndex];
        }

        /// Move to the next player
        public void AdvanceNextPlayer()
        {
            if (_currentPlayerIndex == 0)
            {
                _currentPlayerIndex = 1;
            }
            else if (_currentPlayerIndex == 1)
            {
                _currentPlayerIndex = 0;
                
            }
        }
        
      }
}
