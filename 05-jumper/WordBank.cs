using System;
using System.IO;
using System.Net;

namespace _05_jumper
{
    public class WordBank
    {
        public int _number;
        public string _urlText;
        public int RandomNumber()
        {
            Random randomGenerator = new Random();
            _number = randomGenerator.Next(0,1000);
            return _number;
        }
        public string callurl()  
        {  
            WebRequest request = HttpWebRequest.Create("https://www.mit.edu/~ecprice/wordlist.10000");  
            WebResponse response = request.GetResponse();  
            StreamReader reader = new StreamReader(response.GetResponseStream());  
            _urlText = reader.ReadToEnd(); // it takes the response from your url. now you can use as your need  
            return _urlText;
        }  

        public string RandomWord()
        {
            for ()
        }
    }
}