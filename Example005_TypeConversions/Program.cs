using System;
using static System.Console;
using static System.Convert;

#region Проблема

string s = "1234";

// Ошибка CS0029  Не удается неявно
// преобразовать тип "string" в "int"
//int i = s;     

// Ошибка CS0128  Локальная переменная
// с именем "s" уже определена в этой области
//int s = 1234;  

#endregion

#region Неявное приведение типов

// Типы данных:
// Числовые,
// Логичесике,
// Символы,
// Строки,
// Массивы и т.д.
// Значимые и ссылочные

byte a = 1;     // Задание значения переменной типа byte
short b = a;    // Неявное приведение byte к short
int c = b;      // Неявное приведение short к int
long d = c;     // Неявное приведение int к long
double e = d;   // Неявное приведение long к double

#region Ошибки

//double d = 1;
//long l = d;     // Ошибка CS0266  Не удается неявно преобразовать тип "double" в "long".
//                // Существует явное преобразование(возможно, пропущено приведение типов).
//                // double от ±5,0 × 10^(−324) до ±1,7 × 10^(308)                            // 64 бита
//                // long   от -9 223 372 036 854 775 808 до 9 223 372 036 854 775 807        // 64 бита

//int i = l;      // int От -2 147 483 648  до 2 147 483 647                                  // 32 бита
//                // long   от -9 223 372 036 854 775 808 до 9 223 372 036 854 775 807        // 64 бита

//short s = i;    // int от -2 147 483 648  до 2 147 483 647                                  // 32 бита
//                // short от - 32 768 до 32 767                                              // 16 бит

//byte b = s;     // short от -32 768 до 32 767                                               // 16 бит
//                // byte от 0 до 255                                                         // 8 бит

//sbyte g = -10;  // sbyte от -128 до 127                                                     // 8 бита
//uint u = g;     // uint от 0 до 4294967295u                                                 // 32 бита

#endregion

#endregion

#region Явное приведение типов

//double e = 1.4;
//long d = e;          
// Ошибка CS0266 Не удается неявно преобразовать
// тип "double" в "long".
// Существует явное преобразование
// (возможно, пропущено приведение типов).
// double от ±5,0 × 10^(−324) до ±1,7 × 10^(308)                           // 64 бита
// long от -9 223 372 036 854 775 808 до 9 223 372 036 854 775 807         // 64 бита

//int c = (int)d;      
// int oт -2 147 483 648  до 2 147 483 647                                 // 32 бита
// long от -9 223 372 036 854 775 808 до 9 223 372 036 854 775 807         // 64 бита

//short b = (short)c;  
// int от -2 147 483 648  до 2 147 483 647                                 // 32 бита
// short от - 32 768 до 32 767                                             // 16 бит

//byte a = (byte)b;    // short от - 32 768 до 32 767                                             // 16 бит
// byte от 0 до 255                                                        // 8 бит


//e = 10.98;
//d = (long)e;
//WriteLine($"e = {e}, d = {d}");

//b = 16_100;
//a = (byte)b;
//WriteLine($"b = {b}, a = {a}");

#endregion

#region Метод parse, использование класса Convert

//string s = "123";
//int value = (int)s; 
// Ошибка CS0030  Не удается преобразовать тип "string" в "int" 

//int value = Convert.ToInt32(s);
// using static System.Convert;
//value = ToInt32(s); 
//value = int.Parse(s);
////long.Parse
////double.Parse
////int.Parse
////ushort.Parse

//double e = 1;
//long d = ToInt64(e);
//// long От -9 223 372 036 854 775 808 
////       до 9 223 372 036 854 775 807
//// 64 -разрядное целое число со знаком System.Int64

//int c = ToInt32(d);
//// int От -2 147 483 648 до 2 147 483 647
//// 32 - разрядное целое число со знаком System.Int32

//short b = ToInt16(c);
//// short От -32 768 до 32 767
//// 16 - разрядное целое число со знаком System.Int16

//byte a = ToByte(b);
//// byte От 0 до 255
//// 8 - разрядное целое число без знака System.Byte

// !!! Возможна потеря данных

#region Convert

// Кнопка F12

#endregion

#endregion

#region Метод .ToString()

int value = 1990;
string data = Convert.ToString(value);
data = Convert.ToString(value);
data = value.ToString();

#region Специальное предназначение

long salary = 1234567890;
WriteLine(salary.ToString("### ### ### ###"));

double val = 12345.6789012345;
WriteLine(val.ToString("### ###.##"));

DateTime dateTime = DateTime.Now;
WriteLine($"Текущие дата и время: {dateTime}");
WriteLine($"Текущие дата и время: " +
    $"{dateTime.ToString("MM-dd-yyyy hh-mm")}");
#endregion

#endregion

#region Особый тип

//Операции "упаковать" и "распаковать"(boxing и unboxing).

// упаковка int в object
object obj = 1;       
WriteLine(obj.GetType());

// распаковка int из object
int intValue = ToInt32(obj);        

// упаковка double в object
obj = 20.18;                                
WriteLine(obj.GetType());

// распаковка double из object
double doubleValue = ToDouble(obj); 

// упаковка string в object
obj = "Visual C#";                          
WriteLine(obj.GetType());

// распаковка string из object
string stringValue = Convert.ToString(obj); 
#endregion

#region Замечание

ushort symbol = 'f';
WriteLine(symbol);
char c = (char)(symbol + 10);
WriteLine(c);

#endregion