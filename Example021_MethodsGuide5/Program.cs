using System;
using static System.Console;

#region Актуализация

/// <summary>
/// Метод, описывающий детали подключения к мерверу баз данных
/// </summary>
/// <param name="login">Логин польователя</param>
/// <param name="password">Пароль пользователя</param>
/// <param name="ipServer">IP-Адрес сервера</param>
/// <param name="dataBaseName">Имя базы данных</param>
/// <param name="pooling">Использование пула подключений</param>
/// <param name="value">Значение переменной value</param>
void ConnectionDb1(
                          string login,
                          string password,
                          string ipServer,
                          string dataBaseName,
                          bool pooling,
                          double value
    )
{
    /// Логика работы...
    /// 
    ///
    WriteLine($"Server = {ipServer}");
    WriteLine($"dataBaseName = {dataBaseName}");
    WriteLine($"login = {login}");
    WriteLine($"password = {password}");
    WriteLine($"dataBaseName = {pooling}");
    WriteLine($"value = {value}\n");
}

#endregion

#region Параметры по умолчанию

/// <summary>
/// Метод, описывающий детали подключения к мерверу баз данных
/// </summary>
/// <param name="login">Логин польователя</param>
/// <param name="password">Пароль пользователя</param>
/// <param name="ipServer">IP-Адрес сервера</param>
/// <param name="dataBaseName">Имя базы данных</param>
/// <param name="pooling">Использование пула подключений</param>
/// <param name="value">Значение переменной value</param>
void ConnectionDb2(
                    string login = "Admin",
                    string password = "qwertyu",
                    string ipServer = "127.0.0.1",
                    string dataBaseName = "DemoBase",
                    bool pooling = true,
                    double value = 28.09
    )
{
    /// Логика работы...
    /// 
    ///
    WriteLine($"login = {login}");
    WriteLine($"password = {password}");
    WriteLine($"Server = {ipServer}");
    WriteLine($"dataBaseName = {dataBaseName}");
    WriteLine($"dataBaseName = {pooling}");
    WriteLine($"value = {value}\n");
}

#endregion

#region Массив как параметр

#region Пример 1

/// <summary>
/// Метод, возвращающий сумму чисел
/// </summary>
/// <param name="a1">Первое число</param>
/// <returns>Сумма указанных чисел</returns>
//double Sum(int a1) { return a1; }

/// <summary>
/// Метод, возвращающий сумму чисел
/// </summary>
/// <param name="a1">Первое число</param>
/// <param name="a2">Второе число</param>
/// <returns>Сумма указанных чисел</returns>
//double Sum(int a1, int a2) { return a1 + a2; }

/// <summary>
/// Метод, возвращающий сумму чисел
/// </summary>
/// <param name="a1">Первое число</param>
/// <param name="a2">Второе число</param>
/// <param name="a3">Третье число</param>
/// <returns>Сумма указанных чисел</returns>
//double Sum(int a1, int a2, int a3) { return a1 + a2 + a3; }

/// <summary>
/// Метод, возвращающий сумму чисел
/// </summary>
/// <param name="a1">Первое число</param>
/// <param name="a2">Второе число</param>
/// <param name="a3">Третье число</param>
/// <param name="a4">Четвертое число</param>
/// <returns>Сумма указанных чисел</returns>
//double Sum(int a1, int a2, int a3, int a4) { return a1 + a2 + a3 + a4; }

/// <summary>
/// Метод, возвращающий сумму чисел
/// </summary>
/// <param name="a1">Первое число</param>
/// <param name="a2">Второе число</param>
/// <param name="a3">Третье число</param>
/// <param name="a4">Четвертое число</param>
/// <param name="a5">Пятое число</param>
/// <returns>Сумма указанных чисел</returns>
//double Sum(int a1, int a2, int a3, int a4, int a5) { return a1 + a2 + a3 + a4 + a5; }

#region Частичное решение проблемы, связанной с количеством параметров

/// <summary>
/// Метод, возвращающий сумму чисел суммы
/// </summary>
/// <param name="Args">Набор чисел</param>
/// <returns>Сумма указанных в массиве чисел</returns>
//double Sum(double[] Args)
//{
//    double temp = 0;
//    foreach (var e in Args) temp += e;
//    return temp;
//}

#endregion

#endregion

#region Пример 2

/// <summary>
/// Метод, возвращающий сумму чисел
/// </summary>
/// <param name="Args">Набор чисел</param>
/// <returns>Сумма указанных в массиве чисел</returns>
double Summation(params double[] Args)
{
    double temp = 0;
    foreach (var e in Args) temp += e;
    return temp;
}

// ОШИБКА                   V
//int Summation(string s, int a, params double[] Args)
//{
//    int temp = 0;
//    foreach (var e in Args) temp += e;
//    return temp;
//}

#endregion

#endregion


#region Актуализация
// Меняется только login

//ConnectionDb1("User1", "qwertyu", "127.0.0.1", "DemoBase", true, 28.01);
//ConnectionDb1("User2", "qwertyu", "127.0.0.2", "DemoBase", true, 28.01);
//ConnectionDb1("User3", "qwertyu", "127.0.0.3", "DemoBase", true, 28.01);

#endregion

#region Параметры по умолчанию

// Меняется только login
//ConnectionDb2();
//ConnectionDb2("User1");
//ConnectionDb2("User1", "qwertyu");
//ConnectionDb2("User2", "qwertyu", "192.168.0.1");
//ConnectionDb2("User2", "qwertyu", "192.168.0.1", "Data");
//ConnectionDb2("User2", "qwertyu", "192.168.0.1", "Data", false);
//ConnectionDb2("User2", "qwertyu", "192.168.0.1", "Data", false, 12.34);

#endregion

#region Именованные параметры

// Меняется только login и value
ConnectionDb2(login: "User1", password: "qwertyu", value: 28.01);
ConnectionDb2(ipServer: "123.123.123.1");
ConnectionDb2(pooling: !true);

#endregion

#region Массив как параметр

double resultSum = 0;

resultSum = Summation(1);
resultSum = Summation(1, 2);
resultSum = Summation(1, 2, 3);
resultSum = Summation(1, 2, 3, 4);
resultSum = Summation(1, 2, 3, 4, 5);
//resultSum = Sum(1, 2, 3, 4, 5, 6);
//resultSum = Sum(1, 2, 3, 4, 5, 6, 7);
//resultSum = Sum(1, 2, 3, 4, 5, 6, 7, 8);

// Частичное решение проблемы
double[] numbers = new double[] { 1, 2, 3, 4, 5, 6 };
resultSum = Summation(numbers);

numbers = new double[] { 1, 2, 3, 4, 5, 6, 7 };
resultSum = Summation(numbers);

resultSum = Summation(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });



#region Решение проблемы

resultSum = Summation(1);
resultSum = Summation(1, 2, 3);
resultSum = Summation(1, 2, 3, 4, 5);
resultSum = Summation(1, 2, 3, 4, 5, 6, 7);
resultSum = Summation(1, 2, 3, 4, 5, 6, 7, 8, 9);
resultSum = Summation(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });
// ОШИБКА
//resultSum = Summation(String.Empty, 2018, 123, 444, 555, 666, 777);

#endregion



#endregion