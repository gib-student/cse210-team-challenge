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
        public List<string> _randomWord = new List<string>();
   
        public void Callurl()  
        {  
            using(WebClient client = new WebClient())
            {
                _urlText = client.DownloadString("https://www.mit.edu/~ecprice/wordlist.10000");
            }
        }
        public void CreateList()
        {
            _randomWord = _urlText.Split('\n').ToList();
        }
        
        public void RandomWord()
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, _randomWord.Count);
            _word = _randomWord[number];
        }
    }
}