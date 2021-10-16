using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace _05_jumper
{
    public class WordBank
    {
        static string _urlText;
        static List<string> _randomWords = new List<string>();
        static bool filled = false;
        
        /// Return a random word from the list
        public string RandomWord()
        {
            if (!filled)
            {
                Callurl();
                CompileList();
                filled = true;
            }
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, 10000);
            return _randomWords[number];
        }

        /// Add the word in _urlText to the list of words
        /// Parameters: first and last index of the word from _urlText
        static void CompileList()
        {
            int ifirst = 0;
            int ilast = 0;
            for (int i = 0; i < _urlText.Length; i++)
            {
                if ((int)_urlText[i] == 10)
                {
                    // now we know where the end of the first word is
                    ilast = i - 1;
                    // Move past EOL character (line feed) for the next word
                    i++; 
                    // Add the word we identified into the list
                    AddWord(ifirst, ilast);
                    // move onto the next word
                    ifirst = i;
                }
            }
        }

        /// Get all the words from a file and 
        static void Callurl()  
        {  
            using(WebClient client = new WebClient())
            {
                _urlText = client.DownloadString("https://www.mit.edu/~ecprice/wordlist.10000");
            } 
        }

        /// Add the word within the given indices from the URL text 
        /// into the randomWords list
        static void AddWord(int ifirst, int ilast)
        {
            string word = "";
            for(int i = ifirst; i <= ilast; i++)
            {
                word += _urlText[i];
            }
            _randomWords.Add(word);
        }
    }
}