using System;

namespace _07_speed
{
    /// Store the data which will be in the buffer on the bottom-left of the
    /// window. 
    public class Buffer : Actor
    {
        public Buffer()
        {
            _position = new Point(599, 10);
            _velocity = new Point(10,10);
            _width = 10;
            _height = 6;
        }

        public bool IsMatch(Word word)
        {
            return (word.GetWord() == _text);
        }

        public void AddLetter(string letter)
        {
            _text += letter;
        }

        public override string ToString()
        {
            return _text;
        }

        public void Clear()
        {
            _text = "";
        }
    }
}