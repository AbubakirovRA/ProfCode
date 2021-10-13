#region Теория
#region Начало

////                                       
//// ┌──────────┐                          
//// │   Alen   │  - контейнер / переменная
//// └──────────┘                          
////    user                               
////
//// ┌───────────────────────────────────────────────────────────────────────────────────────────┐
//// │    ┌─────────┐   ┌─────────┐   ┌─────────┐   ┌─────────┐   ┌──────────┐   ┌──────────┐    │
//// │    │  28.09  │   │  11.08  │   │  15.16  │   │  71.81  │   │ 2018.987 │   │     1    │    │
//// │    └─────────┘   └─────────┘   └─────────┘   └─────────┘   └──────────┘   └──────────┘    │
//// │         0             1             2             3             4               5         │
//// └───────────────────────────────────────────────────────────────────────────────────────────┘
////                                    train                                    
////                                                                             
//// train[0], train[1], train[2], train[3], train[4], train[5]                  
//// Индексы меняются от 0 до 5                               

#endregion
#region Актуализация

//int[] arr; // Переменная типа "Массив" (Массив элементов типа int)

//arr = new int[1];
////int a0;

//arr = new int[10];
////int a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;

//arr = new int[100];
////int a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, 
////    a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, 
////    a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, 
////    a31, a32, a33, a34, a35, a36, a37, a38, a39, a40,
////    a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, 
////    a51, a52, a53, a54, a55, a56, a57, a58, a59, a60,
////    a61, a62, a63, a64, a65, a66, a67, a68, a69, a70, 
////    a71, a72, a73, a74, a75, a76, a77, a78, a79, a80,
////    a81, a82, a83, a84, a85, a86, a87, a88, a89, a90,
////    a91, a92, a93, a94, a95, a96, a97, a98, a99;

#endregion
#region Инициализация

//// Способ здания одномерного массива
//// ТипДанных[] Идентификатор массива;
////
//// Инициализация массива
//// ТипДанных[] Идентификатор массива = new ТипДанных[Количество элементов()];
////
//// Вариант 1
//int[] array = new int[2018];            // array.Length
//double[] collection = new double[20];   // collection.Length

////enum Level
////{
////    Easy,
////    Medium,
////    Hard
////}

//Level[] db = new Level[5];              // db.Length

//// Вариант 2

//// 3 элемента   d.Length
//int[] d = { 28, 9, 1990 };

//// 4 элемента math.Length
//double[] math = { 3.141592, 2.718281, 299_792_458, 8.314459 };

//// 5 элементов game.Length
//Level[] games = { Level.Easy, Level.Hard, Level.Hard, Level.Medium, Level.Easy };

#endregion

#endregion

#region Динамический массив и заполнение массива

//Console.WriteLine("Введите число элементов массива A");

//int size = int.Parse(Console.ReadLine());
//int[] A = new int[size];

//for (int i = 0; i < size; i++)
//{
//    Console.Write($"Введите A[{i}]: ");
//    A[i] = Convert.ToInt32(Console.ReadLine());
//}

////for (int i = 0; i < size; i++)
////for (int i = 0; i < A.Length; i++)
////{
////    Console.Write($"{A[i]} ");
////}

//foreach (int e in A)
//{
//    Console.Write($"{e} ");
//}

#endregion

#region Генаратор псевдослучайных чисел

using System;

Random rnd = new Random(58);
//rnd.Next(); // Возвращает случайное целое число со знаком, 
// больше или равно 0 и меньше чем System.Int32.MaxValue.

//rnd.Next(max); // Возвращает случайное целое число со знаком, 
// больше или равно 0 и меньше чем max 10 -> 0 1 2 3 4 5 6 7 8  9

//rnd.Next(min, max); // Возвращает случайное целое число со знаком, 
// больше или равно min и меньше чем max -5  1  -5 -4 -3 -2 -1 0

// rnd.NextDouble()  // Возвращает случайное число с плавающей запятой, 
//                   // которое больше или равно 0,0 и меньше 1,0. 0.... 0.99999999999

//for (int i = 0; i < 100; i++)
//{
//    Console.Write($"{rnd.Next(10)} ");
//}

#endregion

#region Заполнение при помощи генератора случайных чисел

//int length = 10; // int.Parse(Console.ReadLine());


//int[] b = new int[length];

//for (int i = 0; i < b.Length; i++)
//{
//    b[i] = rnd.Next(10);
//    Console.Write($"{b[i]} ");
//}
//Console.WriteLine();

#endregion

#region Изменение размера массива
int length = 5; // int.Parse(Console.ReadLine());
Console.WriteLine("Исходные массив: ");
int[] b = new int[length];

for (int i = 0; i < b.Length; i++)
{
    b[i] = rnd.Next(10);
    Console.Write($"{b[i]} ");
}

#region Шаг 1

//Console.WriteLine("\n\nИзменённый размер массива: ");

//int newLength = 15; // int.Parse(Console.ReadLine());

//b = new int[newLength];

//for (int i = 0; i < b.Length; i++)
//{
//    Console.Write($"{b[i]} ");
//}

#endregion
#region Шаг 2

//int newLength = 15; // int.Parse(Console.ReadLine());
//int[] t = new int[newLength];

//for (int i = 0; i < b.Length; i++)
//{
//    t[i] = b[i];
//}
//int oldLength = b.Length;

//b = t;

//Console.WriteLine("\n\nИзменённый массива b через массив t: ");
//for (int i = oldLength; i < b.Length; i++)
//{
//    b[i] = rnd.Next(10);
//}

//t[10] = 123456;

//for (int i = 0; i < b.Length; i++)
//{
//    Console.Write($"{b[i]} ");
//}

#endregion
#region Шаг 3

//int newLength = 15; // int.Parse(Console.ReadLine());
//int[] t = new int[b.Length];

//for (int i = 0; i < b.Length; i++)
//{
//    t[i] = b[i];
//}
//int oldLength = b.Length;

//b = new int[newLength];

//for (int i = 0; i < t.Length; i++)
//{
//    b[i] = t[i];
//}

//Console.WriteLine("\n\nИзменённый массива b через массив t: ");
//for (int i = oldLength; i < b.Length; i++)
//{
//    b[i] = rnd.Next(10);
//}

//t[1] = 123654;

//for (int i = 0; i < b.Length; i++)
//{
//    Console.Write($"{b[i]} ");
//}

#endregion
#region Шаг 4

//int oldLength = b.Length;
//int newLength = 15; // int.Parse(Console.ReadLine());

//Array.Resize(ref b, newLength);

//for (int i = oldLength; i < b.Length; i++)
//{
//    b[i] = rnd.Next(10);
//}
//Console.WriteLine("\nИзменённый массив b");
//for (int i = 0; i < b.Length; i++)
//{
//    Console.Write($"{b[i]} ");
//}

#endregion
#region Шаг 5

//Array.Sort(b);
//Console.WriteLine("\n\nУпорядоченный массив: ");

//for (int i = 0; i < b.Length; i++) Console.Write($"{b[i]} ");

//Array.Reverse(b);
//Console.WriteLine("\n\nИнвертированный массив: ");

//for (int i = 0; i < b.Length; i++) Console.Write($"{b[i]} ");

#endregion

#endregion

Console.WriteLine();