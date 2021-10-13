using System;
using static System.Console;

/// <summary>
/// Методод возведения числа в квадрат
/// </summary>
/// <param name="x">Число</param>
/// <returns>Квадрат числа</returns>
double f(double x)
{
    return x * x;
}

/// <summary>
/// Метод проверчи числа N на чётность
/// </summary>
/// <param name="N">Число, которое нужно проверить</param>
/// <returns></returns>
bool IsEven(int N)
{
    return N % 2 == 0;
}

/// <summary>
/// Метод удаляющий повторяющиеся символы в строке Str
/// </summary>
/// <param name="Str">Строка, в которой нужно удалить повторяющиеся символы</param>
/// <returns>Строка без повторений</returns>
string DeleteDuplicates(string Str)
{
    // ПППППООООООГГГГГООООДДДДААААА
    string temp = string.Empty;
    Str += " ";
    for (int i = 0; i < Str.Length - 1; i++)
    {
        if (Str[i] != Str[i + 1]) temp += $"{Str[i]}";
    }
    return temp;
}

/// <summary>
/// Метод возвращающий максимальное из трёх чисел
/// </summary>
/// <param name="Value1">Первое число</param>
/// <param name="Value2">Второе число</param>
/// <param name="Value3">Третье число</param>
/// <returns>Максимальное число</returns>
double Max(double Value1, double Value2, double Value3)
{
    if (Value1 > Value2 && Value1 > Value3)
    {
        return Value1;
    }
    else if (Value2 > Value3)
    {
        return Value2;
    }
    else { return Value3; }
}


#region Демонстрация static double f(double x)

//var result = f(5);
//WriteLine($"f(5) = {result}");

//WriteLine("\nТаблица значений функции f(x) = x^2:");
//for (double x = -2; x <= 2; x+=0.5)
//{
//    WriteLine($"f({x,4}) = {f(x)}");
//}

#endregion

#region Демонстрация bool IsEven(int N)

//Write("Введите число: ");
//int numb = Convert.ToInt32(ReadLine());
//Write("Результат: ");
//WriteLine(IsEven(numb) ? "Чётное" : "Нечётное");
//ReadKey();

#endregion

#region Демонстрация string DeleteDuplicates(string Str)

//Write("\nСтрока с повторяющимися символами: ");
//string text = ReadLine();
//Write("Результат: ");
//WriteLine(DeleteDuplicates(text));
//ReadKey();

#endregion

#region Демонстрация double Max(double Value1, double Value2, double Value3)

//Write("\nВведите первое число: ");
//int numb1 = Convert.ToInt32(ReadLine());

//Write("Введите второе число: ");
//int numb2 = Convert.ToInt32(ReadLine());

//Write("Введите третье число: ");
//int numb3 = Convert.ToInt32(ReadLine());

//Write("Результат: ");
//WriteLine($"Максимальное: {Max(numb1, numb2, numb3)}");
//ReadKey();

#endregion