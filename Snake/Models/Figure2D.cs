using System.Collections.Generic;

namespace Snake.Models
{
    public abstract class Figure2D
    {
        public List<Point> elements;

        protected abstract void Draw();
    }
}
