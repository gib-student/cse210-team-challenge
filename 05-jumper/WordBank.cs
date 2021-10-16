using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace _05_jumper
{
    public class WordBank
    {
        public int _number;
        public string _urlText;
        public string _word;
        public List<char> _randomWord = new List<char>();
        // public int RandomNumber()
        // {
        //     Random randomGenerator = new Random();
        //     _number = randomGenerator.Next(0,1000);
        //     return _number;
        // }
        public string Callurl()  
        {  
            // WebRequest request = HttpWebRequest.Create("https://www.mit.edu/~ecprice/wordlist.10000");  
            // WebResponse response = request.GetResponse();  
            // StreamReader reader = new StreamReader(response.GetResponseStream());  
            // string _urlText = reader.ReadToEnd(); // it takes the response from your url. now you can use as your need  
            // return _urlText;

            using(WebClient client = new WebClient())
            {
                _urlText = client.DownloadString("https://www.mit.edu/~ecprice/wordlist.10000");
                return _urlText;
            }
        }  
        public string RandomWord()
        {
            Random randomWord = new Random();
            int i = randomWord.Next(0,5);
            _word = _urlText[i].ToString();
            return _word;
        }
    }
}