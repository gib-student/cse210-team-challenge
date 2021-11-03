using System;

namespace _07_speed
{
    /// Store the data which will be in the buffer on the bottom-left of the
    /// screen. 
    class Buffer : Actor
    {
        private Point _bufferPoint;

        public Buffer()
        {
            _position = new Point(599, 0);
        }

        public void AddLetter(char letter)
        {
            _buffer += letter;
        }

        public override string ToString()
        {
            return _buffer;
        }

        public void Clear()
        {
            _buffer = "";
        }
    }
}