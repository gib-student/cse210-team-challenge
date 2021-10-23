using System;

namespace _06_mastermind
{
    public class Roster
    {
        private int _currentPlayerIndex = 0;
        private List<Player> _players = new List<Player>();
        
        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }
        public player GetCurrentPlayer()
        {
            return _players[_currentPlayerIndex];
        }
        public void AdvanceNextPlayer()
        {
            _currentPlayerIndex = (_currentPlayerIndex + 1) % _players.Count;
        }
        

//         Console.WriteLine("Enter Player One's Name: ");
//         string player_one = Console.ReadLine();
//         Console.WriteLine("Enter Player Two's Name: ");
//         string player_two = Console.ReadLine();
//         Console.WriteLine($"Welcome, {player_one}");
//         Console.WriteLine($"Welcome, {player_two}");
        
      }
}
