using System;

namespace _06_mastermind
{
    public class Roster
    {
        private int _currentPlayerIndex = 0;
        private List<string> _players = new List<string>();
        
        public void AddPlayer(string player)
        {
            _players.Add(player);
        }
        public string GetCurrentPlayer()
        {
            return _players[_currentPlayerIndex];
        }
        public void AdvanceNextPlayer()
        {
            if (_currentPlayerIndex == 0)
            {
                _currentPlayerIndex = 1;
            }
            else if (_currentPLayerIndex == 1)
            {
                _currentlayerIndex = 0;
                
            }
            
          
        }
        
      }
}
