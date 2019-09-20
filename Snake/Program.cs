using System;

namespace Snake
{
    public class Program
    {
        static void Main(string[] args)
        {  
            try
            {
                Console.WriteLine("Введите стартовую длину змейки от 1 до 3...");
                int length = Convert.ToInt32(Console.ReadLine());
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine("Error while type convert: {0}", ex);
            }
            
            /*
             * инициализация змейки и построение игрового поля
             */

        }
    }
}
