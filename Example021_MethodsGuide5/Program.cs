using System;
using static System.Console;

#region Актуализация

/// <summary>
/// Метод, описывающий детали подключения к мерверу баз данных
/// </summary>
/// <param name="Login">Логин польователя</param>
/// <param name="Password">Пароль пользователя</param>
/// <param name="IpServer">IP-Адрес сервера</param>
/// <param name="DataBaseName">Имя базы данных</param>
/// <param name="Pooling">Использование пула подключений</param>
/// <param name="Value">Значение переменной Value</param>
void ConnectionDb1(
                          string Login,
                          string Password,
                          string IpServer,
                          string DataBaseName,
                          bool Pooling,
                          double Value
    )
{
    /// Логика работы...
    /// 
    ///
    WriteLine($"Server = {IpServer}");
    WriteLine($"DataBaseName = {DataBaseName}");
    WriteLine($"Login = {Login}");
    WriteLine($"Password = {Password}");
    WriteLine($"DataBaseName = {Pooling}");
    WriteLine($"Value = {Value}\n");
}

#endregion

#region Параметры по умолчанию

/// <summary>
/// Метод, описывающий детали подключения к мерверу баз данных
/// </summary>
/// <param name="Login">Логин польователя</param>
/// <param name="Password">Пароль пользователя</param>
/// <param name="IpServer">IP-Адрес сервера</param>
/// <param name="DataBaseName">Имя базы данных</param>
/// <param name="Pooling">Использование пула подключений</param>
/// <param name="Value">Значение переменной Value</param>
void ConnectionDb2(
                    string Login = "Admin",
                    string Password = "qwertyu",
                    string IpServer = "127.0.0.1",
                    string DataBaseName = "DemoBase",
                    bool Pooling = true,
                    double Value = 28.09
    )
{
    /// Логика работы...
    /// 
    ///
    WriteLine($"Login = {Login}");
    WriteLine($"Password = {Password}");
    WriteLine($"Server = {IpServer}");
    WriteLine($"DataBaseName = {DataBaseName}");
    WriteLine($"DataBaseName = {Pooling}");
    WriteLine($"Value = {Value}\n");
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
// Меняется только Login

//ConnectionDb1("User1", "qwertyu", "127.0.0.1", "DemoBase", true, 28.01);
//ConnectionDb1("User2", "qwertyu", "127.0.0.2", "DemoBase", true, 28.01);
//ConnectionDb1("User3", "qwertyu", "127.0.0.3", "DemoBase", true, 28.01);

#endregion

#region Параметры по умолчанию

// Меняется только Login
//ConnectionDb2();
//ConnectionDb2("User1");
//ConnectionDb2("User1", "qwertyu");
//ConnectionDb2("User2", "qwertyu", "192.168.0.1");
//ConnectionDb2("User2", "qwertyu", "192.168.0.1", "Data");
//ConnectionDb2("User2", "qwertyu", "192.168.0.1", "Data", false);
//ConnectionDb2("User2", "qwertyu", "192.168.0.1", "Data", false, 12.34);

#endregion

#region Именованные параметры

// Меняется только Login и Value
ConnectionDb2(Login: "User1", Password: "qwertyu", Value: 28.01);
ConnectionDb2(IpServer: "123.123.123.1");
ConnectionDb2(Pooling: !true);

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