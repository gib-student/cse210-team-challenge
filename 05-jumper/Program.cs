using System;

namespace _05_jumper
{
    class Program
    {
        static void Main(string[] args)
        {
            WordBank number = new WordBank();
            number.Callurl();
            number.CreateList();
            number.RandomWord();
            Console.WriteLine(number._word);
            
        }
    }
}
