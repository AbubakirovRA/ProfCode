using System;
using static System.Console;
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
        Write("█");
    }
    WriteLine();
}

WriteLine();
Height = rand.Next(rangeHeightMin, rangeHeightMax);
Width = rand.Next(rangeWidthMin, rangeWidthMax);

for (int i = 0; i < Height; i++)
{
    for (int j = 0; j < Width; j++)
    {
        Write("█");
    }
    WriteLine();
}

WriteLine();
Height = rand.Next(rangeHeightMin, rangeHeightMax);
Width = rand.Next(rangeWidthMin, rangeWidthMax);

for (int i = 0; i < Height; i++)
{
    for (int j = 0; j < Width; j++)
    {
        Write("█");
    }
    WriteLine();
}

#endregion

#region Один из главных принципов, которого нужно придерживаться

// https://ru.wikipedia.org/wiki/Don't_repeat_yourself DRY
// Don’t repeat yourself, DRY(рус.не повторяйся) — это принцип разработки ПО, 
// нацеленный на снижение повторения информации различного рода

#endregion



#region Решение


void DrawRect(int Width, int Height)
{
    for (int i = 0; i < Height; i++)
    {
        for (int j = 0; j < Width; j++)
        {
            Write("█");
        }
        WriteLine();
    }
}

// "Нарисовать" несколько несколько прямоугольников

#region Решение 2

rangeHeightMin = 3;
rangeHeightMax = 5;
rangeWidthMin = 3;
rangeWidthMax = 5;

DrawRect(rand.Next(rangeHeightMin, rangeHeightMax), rand.Next(rangeWidthMin, rangeWidthMax));
WriteLine();

DrawRect(rand.Next(rangeHeightMin, rangeHeightMax), rand.Next(rangeWidthMin, rangeWidthMax));
WriteLine();

DrawRect(rand.Next(rangeHeightMin, rangeHeightMax), rand.Next(rangeWidthMin, rangeWidthMax));
WriteLine();

#endregion

#endregion