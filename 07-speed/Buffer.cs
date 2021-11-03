using System;

namespace _07_speed
{
    /// Store the data which will be in the buffer on the bottom-left of the
    /// window. 
    public class Buffer : Actor
    {
        public Buffer()
        {
            _position = new Point(599, 0);
            _velocity = new Point(0,0);
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