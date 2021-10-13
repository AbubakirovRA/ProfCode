using static System.Console;

#region Пример 1

// for (инициализация счётчика; условие (с участием счётчика); выражение (с участием счётчика))
//     оператор                 | итерация

for (int count = 1; count <= 10; count++)
{
    Write($"{count} ");         // Вывод на экран текущего значения счётчика
}
WriteLine();

string str = "доводы";

int strLength = str.Length;

for (int i = 0; i <= strLength / 2; i++)
{                                                         //|
    if (str[i] == str[strLength - 1 - i])                 //|
        WriteLine($"{str[i]} совпали");           //| итерация
    else                                                  //|
        WriteLine($"{str[i]} не совпали");        //|
}

WriteLine();

#region Общая модель

// Общая модель
// for(инициализаторы; условие; список_выражений) оператор
// 

str = "довод";

strLength = str.Length;

for (int i = 0, j = strLength - 1; i <= j; i++, j--)
{
    if (str[i] == str[j])
        WriteLine($"{str[i]} совпали");
    else
        WriteLine($"{str[i]} не совпали");
}

#endregion

#endregion

#region Пример 2

// Ещё немного for'a

//for (int i = 0; i < 10; i++) { }
//for (int i = 0; i < 10; i += 2) { }
//for (double i = 0; i < 0.5; i += 0.1) { }
//for (double i = 0; i > -1.5; i += -0.5) { }
//for (double i = 0; i > -1.5; i /= 2) { }
//for (double i = 0; i > -1.5; i = i - Math.Sin(i) - i * i) { }
//for (int i = 0, j = 5; i <= j; i++, j--) { }
//for (; ; ) { }

#endregion