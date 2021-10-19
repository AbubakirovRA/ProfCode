// *Ранее назывались "Процедуры"
using System;
using static System.Console;
#region Не принимают параметры, не возвращают результат

/// <summary>
/// Системная пауза
/// </summary>
static void SystemPause()
{
    ReadKey();
}

/// <summary>
/// Метод, отображающий сообщение "Привет, Мир!" в консоли
/// </summary>
static void SayText1()
{
    WriteLine("Привет, Мир!");
}

#endregion

#region Принимают параметры, не возвращают результат

/// <summary>
/// Метод, отображающий сообщение "Привет, Мир!" в консоли count раз
/// </summary>
/// <param name="count">Количество сообшений</param>
void SayText2(byte count)
{
    for (int i = 0; i < count; i++)
    {
        WriteLine("Привет, Мир!");
    }
}

/// <summary>
/// Метод, отображающий сообщение message в консоли count раз
/// </summary>
/// <param name="message">Сообщение, которое нужно показать на экране</param>
/// <param name="count">Количество сообшений</param>
void PrintText(string message, byte count)
{
    for (int i = 0; i < count; i++)
    {
        WriteLine(message);
    }
}

#endregion

// *Ранее назывались "Функции"

#region Не принимают параметры, возвращают результат

/// <summary>
/// Метод, возвращающий сообщение "Привет, Мир!"
/// </summary>
static string SayTextcount1()
{
    return "Привет, Мир!";
}

/// <summary>
/// Метод возвращающий математическую константу "Число π"
/// </summary>
/// <returns></returns>
static double Pi()
{
    return 3.14159265;
}

#endregion

#region Принимают параметры, возвращают результат

/// <summary>
/// Метод, возвращающий сообщение "Привет, Мир!" count раз
/// </summary>
/// <param name="count">Количество сообшений</param>
static string SayTextcount2(byte count)
{
    string msg = string.Empty;

    for (int i = 0; i < count; i++)
    {
        msg += "Привет, Мир! ";
    }
    return msg;
}

/// <summary>
/// Метод, возвращающий сообщение message count раз
/// </summary>
/// <param name="message">Сообщение, которое нужно повторить</param>
/// <param name="count">Количество сообшений</param>
static string SayTextcount3(string message, byte count)
{
    string msg = string.Empty;

    for (int i = 0; i < count; i++)
    {
        msg += message;
    }
    return msg;
}


#endregion
#region Методы, не возвращающие результат

SystemPause();    // Вызов метода void SystemPause()
SayText1();        // Вызов метода void SayText()

SayText2(5);       // Вызов метода void SayText(byte count) и передача в качестве параметра count равного 5

PrintText("Мир прекрасен! ", 3);  // Вызов метода void PrintText(string message, byte count)
                                  // и передача в качестве параметров 
                                  // message равного "Мир прекрасен! "
                                  // и count равного 3

#endregion

#region Методы, не возвращающие результат

string msg = SayTextcount1(); // Вызов метода string SayTextcount1()
var mathPi = Pi();            // Вызов метода double Pi()

WriteLine($"Результат работы SayTextcount(): {msg}");
WriteLine($"Результат работы Pi(): {mathPi}");


msg = SayTextcount2(3);       // Вызов метода string SayTextcount2(byte count) 
                             // и передача в качестве параметра count равного 3

WriteLine($"Результат работы SayTextcount(byte count): {msg}");

msg = SayTextcount3("Это хороший день! ", 5); // Вызов метода 
                                              // string SayTextcount3(string message, byte count)
                                              // и передача в качестве параметров
                                              // message равного "Это хороший день! "
                                              // и count равного 5

WriteLine($"Результат работы SayTextcount(string message, byte count): {msg}");

#endregion

#region Важное замечание
// Сигнатура метода - это перечень типов, которые метод возвращает и принмает в качестве аргументов

// Описание нескольких методов с одинаковым идентификатором, но разными сигнатурами
// называется "Пергрузкой метода"
#endregion