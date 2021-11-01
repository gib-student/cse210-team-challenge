using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace _07_speed
{
    /// What is the purpose of this class?
    public class WordBank
    {
        static string _urlText;
        static string _word;
        static List<string> _randomWord = new List<string>();
        static bool filled = false;
   
        static void Callurl()  
        {  
            using(WebClient client = new WebClient())
            {
                _urlText = client.DownloadString("https://www.mit.edu/~ecprice/wordlist.10000");
            }
        }
        static void CreateList()
        {
            _randomWord = _urlText.Split('\n').ToList();
        }
        
        public string RandomWord()
        {
            if (!filled)
            {
                Callurl();
                CreateList();
                filled = true;
            }
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, _randomWord.Count);
            _word = _randomWord[number];
            return _word;
        }
    }
}