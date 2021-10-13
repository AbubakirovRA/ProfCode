using static System.Console;

#region Switch

// switch (выражение)
// {
//     case Константа 1: операторы break; 
//     ...
//     case Константа K: операторы break;
//     [default: операторы break;]
// }

// Замечание
//
// выражение должно быть возвращать значение следующих типов:
// char;
// string;
// bool;
// целочисленное значение, например int или long;
// значение enum.
// 
// Начиная с C# 7.0 выражение соответствия может
// быть любым выражением, отличным от NULL.

#endregion

#region Пример 1

WriteLine("Введите первую букву времени суток [ У Д В Н ]");
char day = ReadKey().KeyChar;

switch (day)
{
    case 'У': WriteLine("тро"); break;
    case 'Д': WriteLine("ень"); break;
    case 'В': WriteLine("ечер"); break;
    case 'Н': WriteLine("очь"); break;
    default: WriteLine(" - неизвестное время суток"); break;
}

#endregion

#region Пример 2

WriteLine("\nВведите первую букву времени суток [ У Д В Н ]");

day = ReadKey().KeyChar;

switch (day)
{
    case 'У':
        WriteLine("тро");
        break;

    case 'Д':
        WriteLine("ень");
        break;

    case 'В':
        WriteLine("ечер");
        break;

    case 'Н':
        WriteLine("очь");
        break;

    default:
        WriteLine(" - неизвестное время суток");
        break;
}

#endregion

#region Пример 3

WriteLine("\nВведите первую букву времени суток [ У Д В Н ]");

day = ReadKey().KeyChar;

switch (day)
{
    case 'У': WriteLine("тро"); break;
    case 'у': WriteLine("тро"); break;
    case 'Д': WriteLine("ень"); break;
    case 'д': WriteLine("ень"); break;
    case 'В': WriteLine("ечер"); break;
    case 'в': WriteLine("ечер"); break;
    case 'Н': WriteLine("очь"); break;
    case 'н': WriteLine("очь"); break;
    default: WriteLine(" - неизвестное время суток"); break;
}

#endregion

#region Пример 4

WriteLine("\nВведите первую букву времени суток [ У Д В Н ]");

day = ReadKey().KeyChar;

switch (day)
{
    case 'У':
    case 'у': WriteLine("тро"); break;
    case 'Д':
    case 'д': WriteLine("ень"); break;
    case 'В':
    case 'в': WriteLine("ечер"); break;
    case 'Н':
    case 'н': WriteLine("очь"); break;
    default: WriteLine(" - неизвестное время суток"); break;
}

#endregion

#region Замечание 

// switch позволяет делать проверки
// на соответствие типам и значениям
// отдельных характеристик структур/классов

#endregion

#region Проблемы

// Такое этот switch не может
int a = 12;
if (a > 5 && a < 2020) WriteLine("...");

#endregion

#region Expression switch 1
// https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/patterns?f1url=?appId=Dev16IDEF1&l=EN-US&k=k(and_CSharpKeyword);k(DevLang-csharp)&rd=true
day = ReadKey().KeyChar;

string result = day switch
{
    'У' or 'у' => "тро",
    'Д' or 'д' => "ень",
    'В' or 'в' => "ечер",
    'Н' or 'н' => "очь",
    _ => " - неизвестное время суток"
};
WriteLine(result);

#endregion

#region Expression switch 1

double value = 28;

result = value switch
{
    2891990 => "28 9 1990",
    1 or 2 => "1 или 2",
    >3 and <5 => ">3 и <5",
    >=6 and <=10 => ">=6 and <=10",
    12 or >= 13 and <= 20 => "12 or >= 13 and <= 20",
    //not 21 => "not 21",
    22 or 33 or 44 => "22 or 33 or 44",
    double.NaN => "Unknown",
    _ => "other value"
};
WriteLine(result);

#endregion