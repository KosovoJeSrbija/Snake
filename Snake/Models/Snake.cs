using System.Collections.Generic;
using Snake.Mechanics;

namespace Snake.Models
{
    public class Snake
    {
        private readonly string symbol = "~";
        protected Queue<Point> body;
        
        /*
         * Конструктор для создания змейки при начале игры; имеет переменное 
         * количество аргументов, так как игроку дается выбор, какой длины будет
         * змейка при старте
         */
        public Snake(Direction direction, params Point[] args)
        {
            body = new Queue<Point>();
            foreach(Point p in args)
            {
                body.Enqueue(p);
                Point elem = body.Peek();
                elem.Draw(symbol);
            }
        }

        internal void Move(Direction direction)
        {
            Point tail = body.Peek();
            tail.Clear();
            foreach(Point p in body)
            {
                p.Move(direction);
                p.Draw(symbol);
            }
        }
    }
}
