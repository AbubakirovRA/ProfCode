#region Двумерные массивы 

#region Теория

// 1 1 2 3 5 8 13 21 32 - одномерный массив
// 0 1 2 3 4 5  6  7  8
// А если нужна таблица?
// ┌───────────────┐
// │ 1   2   3   4 │  0 строка
// │ 4   5   6   7 │  1 строка
// │ 7   8   9   0 │  2 строка
// └───────────────┘
//   0   1   2   3
//     столбец
//
// ТипДанных[,] ИдентификаторМассива = new ТипДанных[КоличествоСтрок, КоличествоСтолбцов];
//                                                   размерность №0   размерность №1
#endregion

using System;

int[,] matrix = new int[3, 4];

#region Вывод на экран 1

//for (int i = 0; i < 4; i++) { Console.Write($"{matrix[0, i]} "); }
//Console.WriteLine();
//for (int i = 0; i < 4; i++) { Console.Write($"{matrix[1, i]} "); }
//Console.WriteLine();
//for (int i = 0; i < 4; i++) { Console.Write($"{matrix[2, i]} "); }
//Console.WriteLine();

#endregion
#region Вывод на экран 2

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        Console.Write($"{matrix[i, j]} ");
//    }
//    Console.WriteLine();
//}

#endregion
#region Вывод на экран 3

//Console.WriteLine(matrix.Rank);
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.Write($"{matrix[i, j]} ");
//    }
//    Console.WriteLine();
//}

#endregion
#region Вывод на экран 4

//Console.Write("Количество строк: ");
//int row = Convert.ToInt32(Console.ReadLine());

//Console.Write("Количество столбцов: ");
//int col = Convert.ToInt32(Console.ReadLine());

//Random r = new Random();

//int[,] table = new int[row, col];

//for (int i = 0; i < table.GetLength(0); i++)
//{
//    for (int j = 0; j < table.GetLength(1); j++)
//    {
//        table[i, j] = r.Next(1, 5);
//        Console.Write($"{table[i, j]} ");
//    }
//    Console.WriteLine();
//}

//Console.ReadLine();
#endregion

#endregion

#region Многомерные массивы 

// ТипДанных[, ... ,] ИдентификаторМассива = 
// new ТипДанных[размерность №0, размерность №1, ..., размерность №N];
Console.WriteLine("\nint[,,] array3 = new int[2, 3, 4] : ");
int[,,] array3 = new int[2, 3, 4];
Console.WriteLine($"Всего элементов: {array3.Length}");

for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        for (int k = 0; k < array3.GetLength(2); k++)
        {
            Console.WriteLine($"[{i}, {j}, {k}] = {array3[i, j, k]}");
        }
    }
}

int[,,,] array4 = new int[2, 3, 4, 5];

Console.WriteLine("\nint[,,,] array4 = new int[2, 3, 4, 5] : ");
Console.WriteLine($"Всего элементов: {array4.Length}");


for (int i = 0; i < array4.GetLength(0); i++)
{
    for (int j = 0; j < array4.GetLength(1); j++)
    {
        for (int k = 0; k < array4.GetLength(2); k++)
        {
            for (int m = 0; m < array4.GetLength(3); m++)
            {
                Console.WriteLine($"[{i}, {j}, {k}, {m}] = {array4[i, j, k, m]}");
            }
        }
    }
}

int[,,,,] array5 = new int[2, 3, 4, 5, 6];

Console.WriteLine("\nint[,,,,] array5 = new int[2, 3, 4, 5, 6] : ");
Console.WriteLine($"Всего элементов: {array5.Length}");


for (int i = 0; i < array5.GetLength(0); i++)
{
    for (int j = 0; j < array5.GetLength(1); j++)
    {
        for (int k = 0; k < array5.GetLength(2); k++)
        {
            for (int m = 0; m < array5.GetLength(3); m++)
            {
                for (int n = 0; n < array5.GetLength(4); n++)
                {
                    Console.WriteLine($"[{i}, {j}, {k}, {m}, {n}] = {array5[i, j, k, m, n]}");
                }
            }
        }
    }
}

#endregion