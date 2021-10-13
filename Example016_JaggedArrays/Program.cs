using static System.Console;

using System;
#region Массив массивов, задача

// ┌───────────────┐
// │ 0   0   0   0 │  0 строка
// │ 0   0   0   0 │  1 строка
// │ 0   0   0   0 │  2 строка
// └───────────────┘
//   0   1   2   3
//     столбец
//
// int[,] table = new int[3, 4];
//
// Нужно вести учёт в рабочее время (с 8.00 до 19.59) каждые 5 минут
// В нерабочее (с 20.00 до 7.59) - каждые 15 минут

int hour = 24;
int maxLog = 60 / 5;
int[,] table = new int[hour, maxLog];

//for (int i = 0; i < table.GetLength(0); i++)
//{
//    Write($"{i,2}-й час: ");
//    for (int j = 0; j < table.GetLength(1); j++)
//    {
//        Write($"{table[i, j]} ");
//    }
//    WriteLine();
//}

//#region -
//ReadLine();
//Clear();

//for (int i = 0; i < table.GetLength(0); i++)
//{
//    ForegroundColor = ConsoleColor.Gray;
//    Write($"{i,2}-й час: ");
//    for (int j = 0; j < table.GetLength(1); j++)
//    {
//        if (i < 8 || i >= 18)
//            if (j > 4) ForegroundColor = ConsoleColor.Red;
//            else ForegroundColor = ConsoleColor.Gray;
//        else ForegroundColor = ConsoleColor.Gray;

//        Write($"{table[i, j]} ");
//    }
//    WriteLine();
//}

//ForegroundColor = ConsoleColor.Gray;

//#endregion


#endregion

#region Решение:

ReadLine();
Clear();

int[][] reg = new int[hour][];

//reg[0] = new int[60 / 15];
//...
//reg[7] = new int[60 / 15];
//reg[8] = new int[60 / 5];
//...
//reg[19] = new int[60 / 5];
//reg[20] = new int[60 / 15];
//...
//reg[23] = new int[60 / 15];
Random r = new Random();
for (int i = 0; i < hour; i++)
{
    //if (i >= 8 && i <= 19) reg[i] = new int[60 / 5];
    //else 
    reg[i] = new int[r.Next(5, 20)];
}

for (int i = 0; i < reg.Length; i++)
{
    Write($"{i,2}-й час: ");
    for (int j = 0; j < reg[i].Length; j++)
    {
        Write($"{reg[i][j]} ");
    }
    WriteLine();
}

int[][][] arrray = new int[3][][];

#endregion