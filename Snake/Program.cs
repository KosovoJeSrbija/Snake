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
            Console.SetBufferSize(120, 50);
            /*
             * Инициализация змейки с длиной тела, равной 3 и игрового поля. 
             * Начальное положение змейки в центре игрового поля.
             */
            GameBorders gameBorders = new GameBorders(120, 50);

            Models.Snake snake = new Models.Snake(new Point(60, 25),
                Direction.Right, 3
            );

            FoodGenerator gen = new FoodGenerator(120, 50);
            Point foodPoint = gen.GenerateFood();
            foodPoint.Draw(gen.symbol);

            /*
             * Обработка нажатий клавиш управления пользователем
             */
            while(true) 
            {
                if(snake.IsHitWall(gameBorders.borders) || snake.IsHitTail())
                {
                    break;
                }

                if(snake.Eat(foodPoint))
                {
                    foodPoint = gen.GenerateFood();
                    foodPoint.Draw(gen.symbol);
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.ButtonHandler(key.Key);
                }   
            }

            WriteGameOver();
            Console.ReadLine();
        }

        static void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("И Г Р А    О К О Н Ч Е Н А", xOffset + 1, yOffset++);
            WriteText("============================", xOffset, yOffset++);
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
