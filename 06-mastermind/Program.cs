using System;

namespace _06_mastermind
{
    public class Program
    {
        static void Main(string[] args)
        {
            Director _theDirector = new Director();
            _theDirector.StartGame();

            /// Debug
            // Board _board = new Board();
            // _board.AddPlayer("George");
            
        }
    }
}
