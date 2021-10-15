using System;

namespace _05_jumper
{
    class Program
    {
        static void Main(string[] args)
        {
            WordBank number = new WordBank();
            Console.WriteLine(number.RandomNumber());
            Console.WriteLine(number.callurl());
        }
    }
}
