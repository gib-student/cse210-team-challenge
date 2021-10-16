using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace _05_jumper
{
    public class WordBank
    {
        public string _urlText;
        public string _word;
        public List<char> _randomWord = new List<char>();
        public string Callurl()  
        {  
            using(WebClient client = new WebClient())
            {
                _urlText = client.DownloadString("https://www.mit.edu/~ecprice/wordlist.10000");
                return _urlText;
            }
        } 

        public List<char> CreateList()
        {
            foreach (char c in _urlText)
            {
                _randomWord.Add(c);
            }
            return _randomWord;
        }
        
        public string RandomWord()
        {
            //Why wont this work????
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, 1000);
            _word = _randomWord[number];
            return _word;
        }
    }
}