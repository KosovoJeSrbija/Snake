using System;
using Snake.Models;
using Snake.Mechanics;
using System.Threading;

namespace Snake
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Инициализация змейки с длиной тела, равной 3, и построение игрового поля. 
             * Начальное положение змейки в центре игрового поля.
             */
            Point leftUp = new Point(0,2);
            Point rightDown = new Point(100, 30);
            Point leftDown = new Point(leftUp.x_coordinate, rightDown.y_coordinate);
            Point rightUp = new Point(rightDown.x_coordinate, leftUp.y_coordinate);

            HorizontalBorder upHorizontalBorder = new HorizontalBorder(leftUp, rightUp);
            HorizontalBorder downHorizontalBorder = new HorizontalBorder(leftDown, rightDown);

            VerticalBorder leftVerticalBorder = new VerticalBorder(leftUp, leftDown);
            VerticalBorder rightVerticalBorder = new VerticalBorder(rightUp, rightDown);

            Models.Snake snake = new Models.Snake(Direction.Right, new Point[3] {
                new Point(rightDown.x_coordinate / 2 - 1, rightDown.y_coordinate / 2),
                new Point(rightDown.x_coordinate / 2, rightDown.y_coordinate / 2),
                new Point(rightDown.x_coordinate / 2 + 1, rightDown.y_coordinate / 2)
            });

            //while(true)
            //{
                snake.Move(Direction.Right);
                //Thread.Sleep(500);
            //}

            /*
             * Обработка нажатий клавиш управления пользователем
             */
            ConsoleKeyInfo key;
            do
            {
                 key = Console.ReadKey();
                 switch(Convert.ToInt32(key.Key))
                 {
                     case 32:

                         break;
                     case 33:
                         break;
                     case 34:
                         break;
                     case 35:
                         break;
                 }
            }
            while(key.Key != ConsoleKey.Escape);
        }
    }
}
