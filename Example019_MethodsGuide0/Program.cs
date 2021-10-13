using System;

void DrawRect(int Width, int Height)
{
    for (int i = 0; i < Height; i++)
    {
        for (int j = 0; j < Width; j++)
        {
            Console.Write("█");
        }
        Console.WriteLine();
    }
}

// "Нарисовать" несколько несколько прямоугольников

#region Решение 2

Random rand = new Random();

int rangeHeightMin = 3;
int rangeHeightMax = 5;
int rangeWidthMin = 3;
int rangeWidthMax = 5;

DrawRect(rand.Next(rangeHeightMin, rangeHeightMax), rand.Next(rangeWidthMin, rangeWidthMax));
Console.WriteLine();

DrawRect(rand.Next(rangeHeightMin, rangeHeightMax), rand.Next(rangeWidthMin, rangeWidthMax));
Console.WriteLine();

DrawRect(rand.Next(rangeHeightMin, rangeHeightMax), rand.Next(rangeWidthMin, rangeWidthMax));
Console.WriteLine();

#endregion