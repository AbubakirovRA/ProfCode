using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

#region Переменные v 1.0

// ТипДанных имяПеременной;
DayOfWeek today;

short depthSea;
char gender;
uint distance;
ulong distanceAlphaCentauri;

#endregion

#region Оператор присваивания

today = DayOfWeek.Thursday;
depthSea = -11000;
gender = 'f';
distance = 4294967295;
distanceAlphaCentauri = 18446744073709551615;
distanceAlphaCentauri = ulong.MinValue;
distanceAlphaCentauri = ulong.MaxValue;

#endregion

#region Числовые типы данных

// https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/value-types
//
// sbyte:  -128 .. 127
// short:  -32 768 .. 32 767
// int:    -2 147 483 648 .. 2 147 483 647
// long:   -9 223 372 036 854 775 808 .. 9 223 372 036 854 775 807
// byte:    0 .. 255
// ushort:  0 .. 65 535
// uint:    0 .. 4 294 967 295
// ulong:   0 .. 18 446 744 073 709 551 615
// float:   –3,4 × 10^38 .. + 3,4 × 10^38
// double:  ±5,0 × 10^(−324) .. ±1,7 × 10^308
// bool:    true и false
// char:    U+0000 .. U+FFFF

// + Синонимы
// double --> Double
// int --> Int32
// short --> Int16

#endregion

#region Примеры

// ТипДанных имяПеременной = начальноеЗначение;
DayOfWeek tomorrow = DayOfWeek.Thursday;
int value = 1234567;
ushort varUshort = 1990;
double varDouble = 0.9;
sbyte varSbyte = 28;

// byte varShort = 66000; // Ошибка CS0031  
// Значение константы "66000"
// не может быть преобразовано в "byte"

// ushort value = -2018; // Ошибка CS0031  
// Значение константы "-2018"
// не может быть преобразовано в "ushort"

long varLong1 = 250000000000;
long varLong2 = 250_000_000_000;
long varLong3 = 250___000_00__0______________000;

#endregion

#region Неявная типизация

var temp1 = 1; WriteLine(temp1.GetType().Name);
var temp2 = 1.1; WriteLine(temp2.GetType().Name);
var temp3 = "hello"; WriteLine(temp3.GetType().Name);
var temp4 = '-'; WriteLine(temp4.GetType().Name);

// Ошибка CS0029 Не удается неявно преобразовать
// тип "string" в "int"
// var temp5 = -28; WriteLine(temp5.GetType().Name);
// temp5 = "кусь"; WriteLine(temp5.GetType().Name)

#region Пример
WriteLine(new int[] { 1, 2, 3 }.Where(e => e > 5).GetType());
#endregion

#region Решение 
var col = new int[] { 1, 2, 3 }.Where(e => e > 5);

#region Будь проще
IEnumerable<int> data = new int[] { 1, 2, 3 }.Where(e => e > 5);
#endregion
#endregion

#endregion

#region default
// Работает с C# 2.0

int a = default(int); WriteLine($"default(int) = {a}");
bool b = default(bool); WriteLine($"default(bool) = {b}");
byte c = default(byte); WriteLine($"default(byte) = {c}");
char d = default(char); WriteLine($"default(char) = {d}");
double e = default(double); WriteLine($"default(double) = {e}");

// Работает в C# 7.1 и более новых версиях
ulong f = default; WriteLine($"default(ulong) = {f}");
float g = default; WriteLine($"default(int) = {g}");
long h = default; WriteLine($"default(int) = {h}");
short i = default; WriteLine($"default(int) = {i}");

#endregion

#region Строки

char symbol = '!';
string str = "==============================";
WriteLine(str);

str = new string(symbol, 30);
WriteLine(str);
str = new string('+', 30);
WriteLine(str);

#endregion

#region Константы

WriteLine(1);
Write("Огонь? ");
WriteLine('y');

//int monthCount = 12;
//WriteLine(monthCount); // 12
//monthCount = 13;
//WriteLine(monthCount); // 13

const int monthCount = 12;
WriteLine(monthCount); // 12
//monthCount = 13;     // Ошибка CS0131 Левая часть
                       // выражения назначения должна
                       // быть переменной,
                       // свойством или индексатором.	

WriteLine(monthCount); // 12

#endregion