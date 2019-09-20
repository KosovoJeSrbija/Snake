using System.Collections.Generic;

namespace Snake.Models
{
    public abstract class Figure2D
    {
        protected List<Point> elements;

        protected abstract void Draw();
    }
}
