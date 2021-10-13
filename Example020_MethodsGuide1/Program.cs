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
/// Метод, отображающий сообщение "Привет, Мир!" в консоли Count раз
/// </summary>
/// <param name="Count">Количество сообшений</param>
void SayText2(byte Count)
{
    for (int i = 0; i < Count; i++)
    {
        WriteLine("Привет, Мир!");
    }
}

/// <summary>
/// Метод, отображающий сообщение Message в консоли Count раз
/// </summary>
/// <param name="Message">Сообщение, которое нужно показать на экране</param>
/// <param name="Count">Количество сообшений</param>
void PrintText(string Message, byte Count)
{
    for (int i = 0; i < Count; i++)
    {
        WriteLine(Message);
    }
}

#endregion

// *Ранее назывались "Функции"

#region Не принимают параметры, возвращают результат

/// <summary>
/// Метод, возвращающий сообщение "Привет, Мир!"
/// </summary>
static string SayTextCount1()
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
/// Метод, возвращающий сообщение "Привет, Мир!" Count раз
/// </summary>
/// <param name="Count">Количество сообшений</param>
static string SayTextCount2(byte Count)
{
    string msg = string.Empty;

    for (int i = 0; i < Count; i++)
    {
        msg += "Привет, Мир! ";
    }
    return msg;
}

/// <summary>
/// Метод, возвращающий сообщение Message Count раз
/// </summary>
/// <param name="Message">Сообщение, которое нужно повторить</param>
/// <param name="Count">Количество сообшений</param>
static string SayTextCount3(string Message, byte Count)
{
    string msg = string.Empty;

    for (int i = 0; i < Count; i++)
    {
        msg += Message;
    }
    return msg;
}


#endregion
#region Методы, не возвращающие результат

SystemPause();    // Вызов метода void SystemPause()
SayText1();        // Вызов метода void SayText()

SayText2(5);       // Вызов метода void SayText(byte Count) и передача в качестве параметра Count равного 5

PrintText("Мир прекрасен! ", 3);  // Вызов метода void PrintText(string Message, byte Count)
                                  // и передача в качестве параметров 
                                  // Message равного "Мир прекрасен! "
                                  // и Count равного 3

#endregion

#region Методы, не возвращающие результат

string msg = SayTextCount1(); // Вызов метода string SayTextCount1()
var mathPi = Pi();            // Вызов метода double Pi()

WriteLine($"Результат работы SayTextCount(): {msg}");
WriteLine($"Результат работы Pi(): {mathPi}");


msg = SayTextCount2(3);       // Вызов метода string SayTextCount2(byte Count) 
                             // и передача в качестве параметра Count равного 3

WriteLine($"Результат работы SayTextCount(byte Count): {msg}");

msg = SayTextCount3("Это хороший день! ", 5);  // Вызов метода 
                                              // string SayTextCount3(string Message, byte Count)
                                              // и передача в качестве параметров
                                              // Message равного "Это хороший день! "
                                              // и Count равного 5

WriteLine($"Результат работы SayTextCount(string Message, byte Count): {msg}");

#endregion

#region Важное замечание
// Сигнатура метода - это перечень типов, которые метод возвращает и принмает в качестве аргументов

// Описание нескольких методов с одинаковым идентификатором, но разными сигнатурами
// называется "Пергрузкой метода"
#endregion