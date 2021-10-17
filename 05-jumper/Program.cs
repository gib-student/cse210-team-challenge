using System;

namespace _05_jumper
{
    class Program
    {
        static string _randomWord;
        static void Main(string[] args)
        {
            Director theDirector = new Director();
            theDirector.StartGame();
        }
    }
}
