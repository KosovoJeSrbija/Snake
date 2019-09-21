using System;
using Snake.Models;

namespace Snake.Mechanics
{
    public class FoodGenerator
    {
        Random random = new Random();
        public readonly string symbol = "$";

        public int fieldLength;
        public int fieldWidth;

        public FoodGenerator(int fieldWidth, int fieldLength)
        {
            this.fieldWidth = fieldWidth;
            this.fieldLength = fieldLength;
        }

        public Point GenerateFood()
        {
            return new Point(
                random.Next(2, fieldWidth - 2), random.Next(2, fieldLength - 2));
        }
    }
}
