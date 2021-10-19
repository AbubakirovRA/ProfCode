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
bool IsEven(int n)
{
    return n % 2 == 0;
}

/// <summary>
/// Метод удаляющий повторяющиеся символы в строке str
/// </summary>
/// <param name="str">Строка, в которой нужно удалить повторяющиеся символы</param>
/// <returns>Строка без повторений</returns>
string DeleteDuplicates(string str)
{
    // ПППППООООООГГГГГООООДДДДААААА
    string temp = string.Empty;
    str += " ";
    for (int i = 0; i < str.Length - 1; i++)
    {
        if (str[i] != str[i + 1]) temp += $"{str[i]}";
    }
    return temp;
}

/// <summary>
/// Метод возвращающий максимальное из трёх чисел
/// </summary>
/// <param name="value1">Первое число</param>
/// <param name="value2">Второе число</param>
/// <param name="value3">Третье число</param>
/// <returns>Максимальное число</returns>
double Max(double value1, double value2, double value3)
{
    if (value1 > value2 && value1 > value3)
    {
        return value1;
    }
    else if (value2 > value3)
    {
        return value2;
    }
    else { return value3; }
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

#region Демонстрация string DeleteDuplicates(string str)

//Write("\nСтрока с повторяющимися символами: ");
//string text = ReadLine();
//Write("Результат: ");
//WriteLine(DeleteDuplicates(text));
//ReadKey();

#endregion

#region Демонстрация double Max(double value1, double value2, double value3)

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