// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example018_IntroMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // "Нарисовать" несколько несколько прямоугольников

            #region Решение 1. Актуализация

            Random rand = new Random();

            int rangeHeightMin = 3;
            int rangeHeightMax = 5;
            int rangeWidthMin = 3;
            int rangeWidthMax = 5;

            int Height = rand.Next(rangeHeightMin, rangeHeightMax);
            int Width = rand.Next(rangeWidthMin, rangeWidthMax);

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("█");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Height = rand.Next(rangeHeightMin, rangeHeightMax);
            Width = rand.Next(rangeWidthMin, rangeWidthMax);

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("█");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Height = rand.Next(rangeHeightMin, rangeHeightMax);
            Width = rand.Next(rangeWidthMin, rangeWidthMax);

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("█");
                }
                Console.WriteLine();
            }

            #endregion

            #region Один из главных принципов, которого нужно придерживаться

            // https://ru.wikipedia.org/wiki/Don't_repeat_yourself DRY
            // Don’t repeat yourself, DRY(рус.не повторяйся) — это принцип разработки ПО, 
            // нацеленный на снижение повторения информации различного рода

            #endregion


        }



    }
}