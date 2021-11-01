using System;

namespace _07_speed
{
    public class Actor
    {
        protected Point _position;
        protected Point _velocity;

        protected int _fontSize = Constant.DEFAULT_FONT_SIZE;
        protected string _text = "";

        public Actor()
        {

        }

        public bool HasText()
        {
            return _text != "";
        }

        public string GetText()
        {
            return _text;
        }

        public int GetX()
        {
            return _position.GetX();
        }

        public int GetY()
        {
            return _position.GetY();
        }

        public int GetFontSize()
        {
            return _fontSize;
        }

        public Point GetPosition()
        {
            return _position;
        }

        public Point GetVelocity()
        {
            return _velocity;
        }
        
        public void SetVelocity(Point newVelocity)
        {
            _velocity = newVelocity;
        }

        public void MoveNext()
        {
            int x = _position.GetX();
            int y = _position.GetY();

            int dx = _velocity.GetX();
            int dy = _velocity.GetY();

            int newX = (x + dx) % Constant.MAX_X;
            int newY = (y + dy) % Constant.MAX_Y;

            if (newX < 0)
            {
                newX = Constant.MAX_X;
            }

            if (newY < 0)
            {
                newY = Constant.MAX_Y;
            }

            _position = new Point(newX, newY);
        }
    }
}