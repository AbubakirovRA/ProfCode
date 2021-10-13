using System;
using static System.Console;
using static System.Convert;

#region Часть 1.1

//   ЕСЛИ (условие)
//       Оператор 1      | Выполняется, если условие "ИСТИНА"

#endregion

#region Часть 1.2

WriteLine(" Нажмите Y для продолжения? ");

char keyCode = ReadKey().KeyChar;

if (keyCode == 'Y') 
    WriteLine(" Вы решили продолжить...");

#endregion

#region Часть 2.1

//    ЕСЛИ (условие)
//    {
//        Оператор 1        | Выполняется, если условие "ИСТИНА"
//        Оператор 2        |
//        ...               |
//        Оператор N        |
//    }

#endregion

#region Часть 2.2

WriteLine("Нажмите Y для продолжения? ");

keyCode = ReadKey().KeyChar;

if (keyCode == 'Y')
{
    WriteLine(" Вы решили продолжить.");
    WriteLine(" Это правильный выбор!");
}

#endregion

#region Часть 3.1

//    ЕСЛИ (условие)
//        Оператор 1        | Выполняется, если условие "ИСТИНА"
//    ИНАЧЕ
//        Оператор 2        | Выполняется, если условие "ЛОЖЬ"

#endregion

#region Часть 3.2

WriteLine("Вы хотите продолжить? [Y / N]");

keyCode = ReadKey().KeyChar;

if (keyCode == 'Y' || keyCode == 'y')
    WriteLine(" Вы решили продолжить.");
else
    WriteLine(" Вы прервали выполнение.");

#endregion

#region Часть 4.1

//   ЕСЛИ (условие)
//   {
//       Оператор 1         |
//       Оператор 2         | Выполняется, если условие "ИСТИНА"
//       ...                | 
//       Оператор N         |
//   }
//   ИНАЧЕ
//   {
//       Оператор N + 1     |
//       Оператор N + 2     | Выполняется, если условие "ЛОЖЬ"
//       ...                |
//       Оператор N+M       |
//   }

#endregion

#region Часть 4.2

WriteLine("Вы хотите продолжить? [Y / N]");

keyCode = ReadKey().KeyChar;

if (keyCode == 'Y')
{
    WriteLine(" Вы решили продолжить.");
    WriteLine(" Это правильный выбор!");
}
else
{
    WriteLine(" Вы прервали выполнение.");
    WriteLine(" А зря...");
}

#endregion

#region Часть 5

WriteLine("Введите первую букву времени суток [ У Д В Н ]");

char day = ReadKey().KeyChar;

if (day == 'У')
{
    WriteLine("тро");
}
else if (day == 'Д')
{
    WriteLine("ень");
}
else if (day == 'В')
{
    WriteLine("ечер");
}
else if (day == 'Н')
{
    WriteLine("очь");
}
else
{
    WriteLine(" - неизвестное время суток");
}



#endregion

#region Часть 6

WriteLine("Введите первую букву времени суток [ У Д В Н ]");
day = ReadKey().KeyChar;

if (day == 'У')
{
    WriteLine("тро");
}
else
{
    if (day == 'Д')
    {
        WriteLine("ень");
    }
    else
    {
        if (day == 'В')
        {
            WriteLine("ечер");
        }
        else
        {
            if (day == 'Н')
            {
                WriteLine("очь");
            }
            else
            {
                WriteLine(" - неизвестное время суток");
            }
        }
    }
}

#endregion

#region p.s.

// Пользователь вводит два числа
// Нужно вывести максимальное из них

// Приглашение ко вводу первого числа
Write("a = ");                  
// Считывание с клавиатуры первого числа
int a = ToInt32(ReadLine());    

// Приглашение ко вводу второго числа
Write("b = ");                  
// Считывание с клавиатуры второго числа
int b = ToInt32(ReadLine());    

// Переменная для хранения максимального значения
int max;                        


WriteLine("Первый вариант: ");
if (a > b) max = a;
else max = b;
WriteLine($"max = {max}");


// ВЫРАЖЕНИЕ ? значение если ВЫРАЖЕНИЕ ИСТИННО
//           : значение если ВЫРАЖЕНИЕ ЛОЖНО
WriteLine("Второй вариант: ");
max = a > b ? a 
            : b;

max = a > b ? a : b;
WriteLine($"max = {max}");

WriteLine("Третий вариант: ");
if (a > b) WriteLine($"max = {a}");
else WriteLine($"max = {b}");


WriteLine("Четвёртый вариант: ");
WriteLine($"max = {(a > b ? a : b)}");

#endregion


// Оператор поглощения
string s = null;

a = 22;

if (s != null)
{
    s = "notnull";
}

s = s ?? "notnull";
s ??= "notnull";

WriteLine(s);

object indata = "Hello, World!";
if (indata is string outdata)
{
    WriteLine(outdata.ToLower());  
}


int x = 7;
int y = 23;
object yBoxed = y;


if (yBoxed is int) { x = ToInt32(yBoxed); }

if (x is int aval && yBoxed is int bval)
{
    WriteLine(aval + bval);  
}

//if (indata is null)
if (indata is not null)
{
    // ...
}