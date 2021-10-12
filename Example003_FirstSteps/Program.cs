using System;
using static System.Console;

#region Данные

string firstName = "Сергей";
string lastName = "Камянецкий";
string company = "Microsoft";
ulong salary = 380000;
byte age = 31;

#endregion

#region Вывод данных 01.1

Write("Example 01.1: ");
string output1 = "Имя: " + firstName + " Фамилия: " + 
    lastName + " Возраст: " + age + " Место работы: " + company + " Доход: $" + salary;

WriteLine(output1);

ReadKey();

//MARK
// 68 --------------------------------------------------------------
// 130 ---------------------------------------------------------------------------------------------------------------------------

#endregion

#region Вывод данных 01.2

Write("Example 01.2: ");
output1 = "Имя: " + firstName;
output1 += " Фамилия: " + lastName;
output1 += " Возраст: " + age;
output1 += " Место работы: " + company;
output1 += " Доход: $" + salary;
WriteLine(output1);

#region ToDo
// Лучше использовать System.Text.StringBuilder 
#endregion

ReadKey();

#endregion

#region Вывод данных 02
Write("Example 02: ");
string output2 = String.Format(
    "имя: {0} фамилия: {1} возраст: {2}" +
    " место работы: {3} доход: ${4}",
    firstName,
    lastName,
    age,
    company,
    salary);
WriteLine(output2);

ReadKey();


#endregion

#region Вывод данных 03

Write("Example 03: ");
string pattern = "имя: {0} фамилия: {1} возраст: {2}" +
                 " место работы: {3} доход: €{4}";

string output3 = String.Format(pattern,    // Шаблон вывода
                              firstName,   // имя {0}
                              lastName,    // фамиия {1}
                              age,         // возраст {2]
                              company,     // место работы {3}
                              salary       // доход {4}
                              );

WriteLine(output3);

ReadKey();
#endregion

#region Вывод данных 04

Write("Example 04: ");
int numberA = 1990;
int numberB = 28;
int sumNumbers = numberA + numberB;

string patternSum = "{0} + {1} = {2}";

string output4 = 
    String.Format(patternSum, numberA, numberB, sumNumbers);

WriteLine(output4);

ReadKey();


#endregion

#region Вывод данных 05

Write("Example 05: ");
int valueA = 1;
int valueB = 2;
int result = valueA * valueB;

string output5 = 
    String.Format("{0} * {1} = {2}", valueA, valueB, result);

WriteLine(output5);

ReadKey();


#endregion

#region Вывод данных 06

Write("Example 06: ");
valueA = 1;
valueB = 2;
result = valueA - valueB;

//string output6 = String.Format($"{0} + {1} = {2}", valueA, valueB, result);
string output6 = $"{valueA} - {valueB} = {result}";

WriteLine(output6);

ReadKey();


#endregion

#region Escape-последовательности
// https://msdn.microsoft.com/ru-ru/library/h21280bw.aspx

// \a Звонок(предупреждение)
// \b Backspace
// \f Перевод страницы
//Environment.OSVersion
// \n\r Новая строка
// \r Возврат каретки
// \t Горизонтальная табуляция
// \v Вертикальная табуляция
// \' Одиночная кавычка
// \" Двойная кавычка
// \\ Обратная косая черта
// \? Литерал вопросительного знака
// \ ooo Символ ASCII в восьмеричной нотации
// \x hh   Символ ASCII в шестнадцатеричной нотации
// \x hhhh Символ юникода в шестнадцатеричном формате

#endregion

#region Вывод данных 07

Write("Example 07: ");
string output7 = String.Format(
    "имя: {0} \nфамилия: {1} \nвозраст: {2} \n" +
    "место работы: {3} \nдоход: ${4}",
    firstName,
    lastName,
    age,
    company,
    salary);
WriteLine(output7);

ReadKey();
#endregion

#region Вывод данных 08

Write("Example 08: ");
string textFyodorTyutchev = "\nУмом Россию не понять, \nАршином общим не измерить: \nУ ней особенная стать — \nВ Россию можно только верить.\n";
WriteLine(textFyodorTyutchev);

ReadKey();


#endregion

#region Вывод данных 09

// URL: https://docs.microsoft.com/ru-ru/previous-versions/visualstudio/visual-studio-2008/362314fe(v=vs.90)?redirectedfrom=MSDN

Write("Example 09: ");
// Escape-последовательности перестают работать
textFyodorTyutchev = @"Умом Россию не понять, 
Аршином общим не измерить: \n
У ней особенная стать — 
В Россию можно только верить.";
WriteLine(textFyodorTyutchev);

ReadKey();


#endregion

#region Вывод данных 10

WriteLine("Example 10: ");
string line1 = "Умом Россию не понять, ";
string line2 = "Аршином общим не измерить: ";
string line3 = "У ней особенная стать — ";
string line4 = "В Россию можно только верить.";

string text = $@"{line1}
{line2}
{line3}
{line4}
";
WriteLine(text);

#endregion

#region Вывод данных 11

WriteLine("Example 11: ");
int a = 1, b = 2, c = a + b;

string output11 = String.Format("{0} + {1} = {2}", a, b, c);
output11 = String.Format($"{a} + {b} = {c}");
WriteLine(output11);

a = 11; b = 22; c = a * b;
output11 = String.Format($"{a} * {b} = {c}");
WriteLine(output11);

a = 111; b = 222; c = a - b;
output11 = String.Format($"{a} - {b} = {c}");
WriteLine(output11);

ReadKey();

#endregion

#region Вывод данных 12. Выравнивание

WriteLine("\nExample 12: ");

a = 1; b = 2; c = 3;

output11 = String.Format($"{a,3} + {b,3} = {c,3}");
WriteLine(output11);

a = 11; b = 22; c = a * b;
output11 = String.Format($"{a,3} * {b,3} = {c,3}");
WriteLine(output11);

a = 111; b = 222; c = a - b;
output11 = String.Format($"{a,3} - {b,3} = {c,3}");
WriteLine(output11);

ReadKey();

#endregion

#region Вывод данных 13. Выравнивание

WriteLine("\nExample 13: ");

a = 1; b = 2; c = a + b;

output11 = String.Format($"{a,-3} + {b,-3} = {c,3}");
WriteLine(output11);

a = 11; b = 22; c = a * b;
output11 = String.Format($"{a,-3} * {b,-3} = {c,-3}");
WriteLine(output11);

a = 111; b = 222; c = a - b;
output11 = String.Format($"{a,-3} - {b,-3} = {c,-3}");
WriteLine(output11);

ReadKey();

#endregion

#region Вывод данных 14. Выравнивание

WriteLine("\nExample 14.1: ");

a = 1; b = 2; c = a + b;

output11 = String.Format($"{a,3} + {b,3} = {c,3}");
WriteLine(output11);
output11 = String.Format($"{a,-3} + {b,-3} = {c,3}\n");
WriteLine(output11);

WriteLine("\nExample 14.2: ");
a = 12345; b = 67890; c = a + b;

output11 = String.Format($"{a,3} + {b,3} = {c,3}");
WriteLine(output11);
output11 = String.Format($"{a,-3} + {b,-3} = {c,3}\n");
WriteLine(output11);

WriteLine("\nExample 14.3: ");
a = 28; b = int.MaxValue; c = a + b;

output11 = String.Format($"{a,3} + {b,3} = {c,3}");
WriteLine(output11);
output11 = String.Format($"{a,-3} + {b,-3} = {c,3}\n");
WriteLine(output11);

WriteLine("\nExample 14.4: ");
output11 = String.Format($"{a,5} + {b,5} = {c,5}");
WriteLine(output11);
output11 = String.Format($"{a,-5} + {b,-5} = {c,5}\n");
WriteLine(output11);

WriteLine("\nExample 14.5: ");
output11 = String.Format($"{a,8} + {b,8} = {c,8}");
WriteLine(output11);
output11 = String.Format($"{a,-8} + {b,-8} = {c,8}\n");
WriteLine(output11);

ReadKey();
#endregion

#region Вывод данных 15. Формат
// Строки стандартных числовых форматов
// Форматирующие строки
// URL: https://docs.microsoft.com/ru-ru/dotnet/standard/base-types/standard-numeric-format-strings

decimal value = 123.456m;
WriteLine(value.ToString("C2")); // 123.46₽
WriteLine(value.ToString("F5")); // 123.45600

value = 123.456m;
WriteLine("Ваш баланс {0:C2}", value); // Ваш баланс 123.46₽

WriteLine("{0,-28:C2}{1,14:C2}", value, 4.16m);
WriteLine("{0,-28:C2}{1,14:C2}", value, 24.16m);
WriteLine("{0,-28:C2}{1,14:C2}", value, 794.16m);
WriteLine("{0,-28:C2}{1,14:C2}", value, 8794.16m);
WriteLine("{0,-28:C2}{1,14:C2}", value, 18794.16m);
#endregion