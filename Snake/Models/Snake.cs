using System;
using System.Collections.Generic;
using System.Linq;
using Snake.Mechanics;

namespace Snake.Models
{
    public class Snake
    {
        private readonly string symbol = "#";
        protected List<Point> body;
        protected Direction direction;
        
        /*
         * Конструктор для создания змейки при начале игры; имеет переменное 
         * количество аргументов, так как игроку дается выбор, какой длины будет
         * змейка при старте
         */
        public Snake(Point tail, Direction direction, int length)
        {
            body = new List<Point>();
            for(int i = 0; i < length; i++)
            {
                Point point = new Point(tail);
                point.Move(i, direction);
                body.Add(point);
                point.Draw(symbol);
            }
        }

        internal void Move()
        {
            Point tail = body.First();
            body.Remove(tail);
            tail.Clear();

            Point newHead = CreateNewHead();
        }

        public void ButtonHandler(ConsoleKey key)
        {
            switch(key)
            {
                case ConsoleKey.UpArrow:
                    direction = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.Down;
                    break;
                case ConsoleKey.LeftArrow:
                    direction = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Direction.Right;
                    break;
            }
        }

        protected Point CreateNewHead()
        {
            Point head = body.Last();
            Point newHead = new Point(head);
            body.Add(newHead);
            newHead.Move(1, direction);
            newHead.Draw(symbol);

            return newHead;
        }

        protected void CreateNewHead(Point point)
        {
            body.Add(point);
            point.Move(1, direction);
            point.Draw(symbol);
        }

        internal bool Eat(Point food)
        {
            Point currentHead = body.Last();
            if(currentHead.IsHit(food))
            {
                CreateNewHead();
                return true;
            } 
            else
            {
                return false;
            }
        }

        public bool IsHitTail()
        {
            Point head = body.Last();
            for(int i = 0; i < body.Count - 2; i++)
            {
                if(head.IsHit(body[i]))
                    return true;
            }
            return false;
        }

        public bool IsHitWall(List<Figure2D> walls)
        {
            Point head = body.Last();
            foreach(Figure2D wall in walls)
            {
                foreach(Point p in wall.elements)
                {
                    if(head.IsHit(p)) return true;
                }
            }
            return false;
        }
    }
}
