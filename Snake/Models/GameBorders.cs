using System.Collections.Generic;

namespace Snake.Models
{
    public class GameBorders
    {
        public List<Figure2D> borders;

        public GameBorders(int width, int height)
        {
            borders = new List<Figure2D>();

            Point leftUp = new Point(0, height - 48);
            Point rightDown = new Point(width - 2, height - 2);
            Point leftDown = new Point(leftUp.x_coordinate, rightDown.y_coordinate);
            Point rightUp = new Point(rightDown.x_coordinate, leftUp.y_coordinate);

            HorizontalBorder upHorizontalBorder = new HorizontalBorder(leftUp, rightUp);
            HorizontalBorder downHorizontalBorder = new HorizontalBorder(leftDown, rightDown);

            VerticalBorder leftVerticalBorder = new VerticalBorder(leftUp, leftDown);
            VerticalBorder rightVerticalBorder = new VerticalBorder(rightUp, rightDown);

            borders.Add(upHorizontalBorder);
            borders.Add(downHorizontalBorder);
            borders.Add(leftVerticalBorder);
            borders.Add(rightVerticalBorder);
        }

        //internal bool IsHit(Snake snake)
        //{
        //    foreach(var border in borders)
        //    {
        //        if(border.IsHit(snake))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }

    public class HorizontalBorder : Figure2D
    {
        protected readonly string symbol = "+"; 
        public HorizontalBorder(Point p1, Point p2)
        {
            elements = new List<Point>();
            for(int i = p1.x_coordinate; i <= p2.x_coordinate; i++)
            {
                elements.Add(new Point(i, p1.y_coordinate));
            }
            Draw();
        }

        protected override void Draw()
        {
            foreach(Point p in elements)
            {
                p.Draw(symbol);
            }
        }
    }

    public class VerticalBorder : Figure2D
    {
        protected readonly string symbol = "+";
        public VerticalBorder(Point p1, Point p2)
        {
            elements = new List<Point>();
            for(int i = p1.y_coordinate; i <= p2.y_coordinate; i++)
            {
                elements.Add(new Point(p2.x_coordinate, i));
            }
            Draw();
        }

        protected override void Draw()
        {
            foreach(Point p in elements)
            {
                p.Draw(symbol);
            }
        }
    }
}
