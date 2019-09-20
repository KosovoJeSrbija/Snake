using System.Collections.Generic;

namespace Snake.Models
{
    public class GameBorders
    {
        public readonly string symbol = "+"; 
    }

    public class HorizontalBorder : Figure2D
    {
        private GameBorders gameBorders;
        public HorizontalBorder(Point p1, Point p2)
        {
            elements = new List<Point>();
            for(int i = p1.x_coordinate; i <= p2.x_coordinate; i++)
            {
                elements.Add(new Point(i, p2.y_coordinate));
            }
            gameBorders = new GameBorders();
            Draw();
        }

        protected override void Draw()
        {
            foreach(Point p in elements)
            {
                p.Draw(gameBorders.symbol);
            }
        }
    }

    public class VerticalBorder : Figure2D
    {
        private GameBorders gameBorders;
        public VerticalBorder(Point p1, Point p2)
        {
            elements = new List<Point>();
            for(int i = p1.y_coordinate; i <= p2.y_coordinate; i++)
            {
                elements.Add(new Point(p2.x_coordinate, i));
            }
            gameBorders = new GameBorders();
            Draw();
        }

        protected override void Draw()
        {
            foreach(Point p in elements)
            {
                p.Draw(gameBorders.symbol);
            }
        }
    }
}
