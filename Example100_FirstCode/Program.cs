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

// Шаг первый: решить как-нибудь

Write("Введите первое число: ");
string input = Console.ReadLine();
int x = int.Parse(input);

Write("Введите второе число: ");
input = Console.ReadLine();
int y = int.Parse(input);

Write("Введите третье число: ");
input = Console.ReadLine();
int z = int.Parse(input);

WriteLine($"x:{x}  y:{y}  z:{z}");

Write("Введите операцию: / * + - ^: ");
string operation = Console.ReadLine();

int result = 0;
if (operation == "/") result = x / y / z;
if (operation == "*") result = x * y * z;
if (operation == "+") result = x + y + z;
if (operation == "-") result = x - y - z;
if (operation == "^") result = x ^ y ^ z;

WriteLine($"result = {result}");