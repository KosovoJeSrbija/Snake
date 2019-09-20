using System.Collections.Generic;

namespace Snake.Models
{
    public class Snake
    {
        private Stack<Point> body;
        
        /*
         * Конструктор для создания змейки при начале игры  
         */
        public Snake(params Point[] args)
        {
            body = new Stack<Point>();
            foreach(Point p in args)
            {
                body.Push(p);
            }

            Move();
        }

        public void Move()
        {
            
        }

        
    }
}
