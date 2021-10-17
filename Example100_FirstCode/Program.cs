using System;
using static System.Console;
// Необычный калькулятор

// Получить первое число
// Получить второе число
// Получить третье число
// Определите какие операции может выполнять ваш калькулятор
// Спросить какую операцию выполнить
// Показать результат
// Подумать над тем, какие проблемы созданы или могут быть созданы

#region Шаг первый: решить как-нибудь
// Write("Введите первое число: ");
// string input = Console.ReadLine();
// double x = double.Parse(input);
// Write("Введите второе число: ");
// input = Console.ReadLine();
// double y = double.Parse(input);
// Write("Введите третье число: ");
// input = Console.ReadLine();
// double z = double.Parse(input);
// WriteLine($"x:{x}  y:{y}  z:{z}");
// Write("Введите операцию: / * + - ^: ");
// string operation = Console.ReadLine();
// double result = 0;
// if (operation == "/") result = x / y / z;
// if (operation == "*") result = x * y * z;
// if (operation == "+") result = x + y + z;
// if (operation == "-") result = x - y - z;
// if (operation == "^") result = Math.Pow(x,Math.Pow(y,z));
// WriteLine($"result = {result}");
#endregion

#region Шаг второй: решить как-нибудь
Write("Введите первое число: ");
string input = Console.ReadLine();
double x = double.Parse(input);

Write("Введите второе число: ");
input = Console.ReadLine();
double y = double.Parse(input);

Write("Введите третье число: ");
input = Console.ReadLine();
double z = double.Parse(input);

WriteLine($"x:{x}  y:{y}  z:{z}");

Write("Введите операцию: / * + - ^: ");
string operation = Console.ReadLine();

//// double result = 0;
//// if (operation == "/") result = x / y / z;
//// if (operation == "*") result = x * y * z;
//// if (operation == "+") result = x + y + z;
//// if (operation == "-") result = x - y - z;
//// if (operation == "^") result = Math.Pow(x,Math.Pow(y,z));

double result = operation switch
{
    "/" => x / y / z,
    "*" => x * y * z,
    "-" => x - y - z,
    "+" => x + y + z,
    _ => Math.Pow(Math.Pow(x, y),z)
};

WriteLine($"result = {result}");
#endregion  