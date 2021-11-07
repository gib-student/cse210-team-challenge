using System;

namespace _07_speed
{
    public class Word : Actor
    {
        public Word(string text)
        {
            _text = text;

            //Choose a random y spot for the new word
            Random randomGenerator = new Random();
            int y = randomGenerator.Next(0, Constant.MAX_Y);

            //Set the new position furthest to the right of the screen with random y
            _position = new Point(Constant.MAX_X, y);
            _width = 0;
            _height = 0;

            //Choose a random speed
            int dx = randomGenerator.Next(1, Constant.MAX_WORD_SPEED);
            _velocity = new Point(-dx, 0);
        }
        
        public int GetPoints()
        {
            return _text.Length;
        }

        public string GetWord()
        {
            return _text;
        }
    }
}