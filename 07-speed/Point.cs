using System;

namespace _07_speed
{
    class Point
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
        }

        public Point Add(Point other)
        {
            int newX = _x + other._x;
            int newY = _y + other._y;

            return new Point(newX, newY);
        }

        
    }
}