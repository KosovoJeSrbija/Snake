using System;
using Snake.Mechanics;

namespace Snake.Models
{
    public class Point
    {
        private readonly string space = " ";
        public int x_coordinate;
        public int y_coordinate;

        public Point(int x_coordinate, int y_coordinate)
        {
            this.x_coordinate = x_coordinate;
            this.y_coordinate = y_coordinate;
        }

        public Point(Point p)
        {
            x_coordinate = p.x_coordinate;
            y_coordinate = p.y_coordinate;
        }

        public void Move(Direction direction)
        {
            switch(direction)
            {
                case Direction.Down:
                    y_coordinate -= 1;
                    break;
                case Direction.Up:
                    y_coordinate += 1;
                    break;
                case Direction.Left:
                    x_coordinate -= 1;
                    break;
                case Direction.Right:
                    x_coordinate += 1;
                    break;
            }
        }

        public void Draw(string symbol)
        {
            Console.SetCursorPosition(x_coordinate, y_coordinate);
            Console.Write(symbol);
        }

        public void Clear()
        {
            Draw(space);
        }
    }
}
