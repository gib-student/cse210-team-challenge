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
            // Hint _hint = new Hint();
            // Console.WriteLine(_hint.GetHint("9194","0010"));
            // Console.WriteLine(_hint.GetHint("1040","2245"));
            // Console.WriteLine(_hint.GetHint("1859","2844"));
            // Console.WriteLine(_hint.GetHint("2958","2848"));
            // Console.WriteLine(_hint.GetHint("9194","1874"));
            // Console.WriteLine(_hint.GetHint("8491","0242"));
            // Console.WriteLine(_hint.GetHint("4774","9194"));
            
        }
    }
}
