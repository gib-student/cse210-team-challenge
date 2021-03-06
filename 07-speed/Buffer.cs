using System;

namespace _07_speed
{
    /// Store the data which will be in the buffer on the bottom-left of the
    /// window. 
    public class Buffer : Actor
    {
        public Buffer()
        {
            _text = "Buffer: ";
            _position = new Point(20, 370);
            _velocity = new Point(0,0);
            _width = 20;
            _height = 20;
        }

        public bool IsMatch(Word word)
        {
            return (_text.Contains(word.GetWord()));
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
            _text = "Buffer: ";
        }
    }
}