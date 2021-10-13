using static System.Console;
using static System.Convert;
using System;

#region Побитовые операции с числами

WriteLine("Побитовые операции с числами");
int a = 13;
int b = 6;
WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"{a} & {b} = {a & b}"); // 4
WriteLine($"{a} | {b} = {a | b}"); //15
WriteLine($"{a} ^ {b} = {a ^ b}\n");

////   1101 
////   0110
//// & 0100

////   1101 
////   0110
//// | 1111

#endregion

#region Операции сдвига

WriteLine(">>");

int year = 2021;
WriteLine($"year = {year,10} {Convert.ToString(year, 2),12}");
WriteLine($"year >> 1 = {year >> 1,5} {Convert.ToString(year >> 1, 2), 12}");   // Побитовый сдвиг вправо на 1 бит
WriteLine($"year >> 2 = {year >> 2,5} {Convert.ToString(year >> 2, 2),12}");    // Побитовый сдвиг вправо на 2 бит
WriteLine($"year >> 3 = {year >> 3,5} {Convert.ToString(year >> 3,2),12}");     // Побитовый сдвиг вправо на 3 бит

WriteLine("\n<<");
year = 2025;
WriteLine($"year = {year}");
WriteLine($"year << 1 = {year << 1,5} {Convert.ToString(year << 1, 2),20}");    // Побитовый сдвиг вправо на 1 бит
WriteLine($"year << 2 = {year << 2,5} {Convert.ToString(year << 2, 2),20}");    // Побитовый сдвиг вправо на 2 бит
WriteLine($"year << 3 = {year << 3,5} {Convert.ToString(year << 3, 2),20}");    // Побитовый сдвиг вправо на 3 бит


#endregion

#region ToDo

int o = 13;
int p = 6;
o = (o ^ p) ^ p;
// Таблица истинности

WriteLine($"a = {a}, b = {b}");

WriteLine($"(a ^ b) ^ b = {(a ^ b) ^ b}");
var res = a ^ b;
WriteLine($"res = {res}");
var totals = res ^ b;
WriteLine($"totals = {totals}");

#endregion