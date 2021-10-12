using static System.Console;

#region Cтандартные арифметические операции -,*,/,+

#region Сумма [+]

int valueInt1 = 2; 
int valueInt2 = 3;
int valueInt3 = valueInt1 + valueInt2;

double valueDouble1 = 2; 
double valueDouble2 = 3;
double valueDouble3 = valueDouble1 + valueDouble2;

sbyte valueSByte1 = 2; 
short valueSByte2 = 3;
var valueSByte3 = valueSByte1 + valueSByte2;

long valueLong1 = 2; 
byte valueLong2 = 3;
var valueLong3 = valueLong1 + valueLong2;

#endregion

#region Разность [-]

valueInt1 = 2;
valueInt2 = 3;
valueInt3 = valueInt1 - valueInt2;

valueDouble1 = 2;
valueDouble2 = 3;
valueDouble3 = valueDouble1 - valueDouble2;

valueSByte1 = 2;
valueSByte2 = 3;
valueSByte3 = valueSByte1 - valueSByte2;

valueLong1 = 2;
valueLong2 = 3;
valueLong3 = valueLong1 - valueLong2;

#endregion

#region  Произведение [*]

valueInt1 = 2;
valueInt2 = 3;
valueInt3 = valueInt1 * valueInt2;

valueDouble1 = 2;
valueDouble2 = 3;
valueDouble3 = valueDouble1 * valueDouble2;

valueSByte1 = 2;
valueSByte2 = 3;
valueSByte3 = valueSByte1 * valueSByte2;

valueLong1 = 2;
valueLong2 = 3;
valueLong3 = valueLong1 * valueLong2;

#endregion

#region  Частное [/]

int a = 4;
int b = 2;
int div1 = a / b;
WriteLine($"div: {a} / {b} = {div1}");

int div2 = b / a;
WriteLine($"div2: {b} / {a} = {div2}");

#region Пояснение

WriteLine("Деление в целых чисах [ byte, int, ulong и т.д.]");

// 30 / 5 = 6
// Делимое / Делитель = Частное
// 30 = 5 * 6
// 
// 32 / 5 = 6 + 2
//
// a = b * q + r        /                  %  
// Делимое / Делитель = Неполное частное + Остаток [ 0 ⩽ Остаток < |Делитель| ]
// 32 = 5 * 6 + [остаток] 2
// -45 / 6 = -8 + [остаток] 3

// 
a = 32;
b = 5;
WriteLine($"{a} / {b} = {a / b} + {a % b}");

a = 41;
b = 6;
WriteLine($"{a} / {b} = {a / b} + {a % b}");

a = -42; b = 6;
WriteLine($"{a} / {b} = {a / b} + {a % b}");

// https://skysmart.ru/articles/mathematic/delenie-chisel-s-ostatkom
a = -17; b = 5;
WriteLine($"!!! {a} / {b} = {a / b} + {a % b}");

a = -17; b = -5;
WriteLine($"!!! {a} / {b} = {a / b} + {a % b}");

WriteLine("\nДеление в вещественных чисах [ double, float]\n");

double i = -17;
double j = 5;

WriteLine($"{i} / {j} = {i / j} ");

float m = 28;
double n = -4;
WriteLine($"{m} / {n} = {m / n} ");

WriteLine(a / b);
//WriteLine(a / (double)b);


#endregion

#endregion

#endregion

#region Постфиксный и префиксный декремент/инкремент

WriteLine("Постфиксный и префиксный декремент/инкремент\n");
int inc = 2017;
WriteLine($"inc = {inc}");
inc = inc + 1;
// inc++;
// ++inc;
WriteLine($"inc = {inc}\n");

double d = 2000;
WriteLine($"d = {d}");
d++;
WriteLine($"d = {d}\n");

int dec = 2011;
WriteLine($"dec = {dec}");
dec = dec - 1;
// dec--;
// --dec;
WriteLine($"dec = {dec}\n");

// Приоритет
int k = 10;

WriteLine($"k = {k}");
WriteLine($"k-- = {k--}");
WriteLine($"k = {k}\n");

k = 10;
WriteLine($"k = {k}");
WriteLine($"--k = {--k}");
WriteLine($"k = {k}");

#endregion

#region Сокращённые формы арифметических операций

// variable = variable - value
// variable -= value

// variable = variable + value
// variable += value

// variable = variable / value
// variable /= value

// variable = variable * value
// variable *= value

// variable = variable % value
// variable %= value

a = 3;
b = 2;
WriteLine($"Умножение: a = {a}, b = {b}");
b *= a;
WriteLine($"a = {a}, b = {b}");
a *= b;
WriteLine($"a = {a}, b = {b}\n");

a = 12;
b = 6;
WriteLine($"Разность: a = {a}, b = {b}");
b -= a;
WriteLine($"a = {a}, b = {b}");
a -= b;
WriteLine($"a = {a}, b = {b}\n");

a = 12;
b = 6;
WriteLine($"Сумма: a = {a}, b = {b}");
b += a;
WriteLine($"a = {a}, b = {b}");
a += b;
WriteLine($"a = {a}, b = {b}\n");

a = 6;
b = 12;
WriteLine($"Частное: a = {a}, b = {b}");
b /= a;
WriteLine($"a = {a}, b = {b}");
a /= b;
WriteLine($"a = {a}, b = {b}\n");

a = 12;
b = 6;
WriteLine($"Остаток от деления: a = {a}, b = {b}");
b %= a;
WriteLine($"a = {a}, b = {b}");
a %= b;
WriteLine($"a = {a}, b = {b}\n");

#endregion

#region Унарный [-] и [+]

a = +10;
b = +20;
WriteLine($"a = {a}, b = {b}");

a = -10;
b = -20;
WriteLine($"a = {a}, b = {b}");

a = -a;
b = -b;
WriteLine($"a = {a}, b = {b}\n");

short s = -10;
var result = +(long)+(int)-(sbyte)-s;

#region Решение

result = +((long)( +(int)( -((sbyte)-s) ) ) );
WriteLine($"+(long)+(int)-(sbyte)-s: result = {result}");
#endregion

#endregion

#region Приоритет операций 

// 
// Унарный +, -
// Префиксный инкремент
// %, /, * 
// +, -
// Постфиксный инкремент
// () - скобки меняют приоритет операций
//

WriteLine($"5 * 6 % 4 = {5 * 6 % 4}");

a = 10;
a = ++a + a++;
WriteLine($"a = {a}");

WriteLine($"2 + 2 * 2 = {2 + 2 * 2}");
WriteLine($"(2 + 2) * 2 = {(2 + 2) * 2}");

#endregion

#region Замечание. !!!! unchecked удалить

byte val1 = byte.MaxValue;    // byte val1 = 255;
Write($"255++  Ожидание: {val1 + 1} ");
val1++;
WriteLine($" Реальность: {val1}");

val1 = byte.MaxValue;    // byte val1 = 255;

checked
{
    unchecked
    { 
        val1++; // val1 = val1 + 1;
    }
} 
// OverflowException: Arithmetic operation resulted in an overflow
 
//// Ключевое слово checked используется для явного включения 
//// проверки переполнения при выполнении арифметических операций и
//// преобразований с данными целого типа.

//// Ключевое слово unchecked позволяет предотвратить проверку 
//// переполнения при выполнении арифметических операций и 
//// преобразований с данными целого типа.

#endregion