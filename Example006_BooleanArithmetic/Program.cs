#region Логический тип данных. Теория

using static System.Console;

bool variable1 = true;      // 1
bool variable2 = false;     // 0

// Высказывание - повествовательное предложение, 
// которое можно подтвердить или опровергнуть
// Пример 1.1: Ближайшая к нам звезда - Солнце - истина
// Пример 1.2: На планете Земля двенадцать материков - ложь
// Пример 1.3: За окном - зима 

#endregion

#region Операции

WriteLine("Таблица истинности");

#region Инверсия 
//      Отрицание / Логическое "Не" /
//      !

WriteLine("Инверсия: ");
// Определение 1. Отрицанием суждения, будет являться суждение
//                «противоположное» исходному

WriteLine($"variable1 = {variable1}   !variable1 = {!variable1}");
WriteLine($"variable2 = {variable2}   !variable2 = {!variable2}");

#endregion

#region Конъюнкция 
//      Логическое умножение / Логическое "И" /
//      &&

WriteLine("\nКонъюнкция: ");

// Определение 2.
// Конъюнкцией двух суждений, будет является суждение
// истинное тогда, когда оба исходных суждения истинны

// Пример 2.1: Ближайшая к нам звезда - Солнце И в году 12 месяцев
// Пример 2.2: В феврале не более 30 дней И день сменяется ночью

variable1 = true;
variable2 = false;

bool result = variable1 & variable2;

WriteLine($" {true} & {true}  = {true & true}");
WriteLine($" {true} & {false} = {true & false}");
WriteLine($"{false} & {true}  = {false & true}");
WriteLine($"{false} & {false} = {false & false}");

#endregion

#region Дизъюнкция  
//      Логическое сложение / Логическое "ИЛИ" /
//      ||

WriteLine("\nДизъюнкция: ");

// Определение 3.
// Дизъюнкцией двух суждений, будет является суждение
// ложное тогда, когда оба исходных суждения ложны

// Пример 3.1: Ближайшая к нам звезда - Солнце ИЛИ в году 18 месяцев
// Пример 3.2: В феврале 30 дней ИЛИ день сменяется ночью
// Пример 3.3: В феврале не более 30 дней ИЛИ день сменяется ночью
// Пример 3.4: В феврале 30 дней ИЛИ в году 18 месяцев

variable1 = true;
variable2 = false;

result = variable1 | variable2;

WriteLine($" {true} | {true}  = {true | true}");
WriteLine($" {true} | {false} = {true | false}");
WriteLine($"{false} | {true}  = {false | true}");
WriteLine($"{false} | {false} = {false | false}");

#endregion

#region Разделительная дизъюнкция  
//      Строгая дизъюнкция / Исключающее «ИЛИ» /
//      ^

WriteLine("\nРазделительная дизъюнкция: ");

// Определение 4.
// Разделительной дизъюнкцией двух суждений, будет является суждение
// истинное тогда, когда только одно из исходных суждения истинно

variable1 = true;
variable2 = false;

result = variable1 ^ variable2;

WriteLine($" {true} ^ {true}  = {true ^ true}");
WriteLine($" {true} ^ {false} = {true ^ false}");
WriteLine($"{false} ^ {true}  = {false ^ true}");
WriteLine($"{false} ^ {false} = {false | false}");

#endregion

#region Математические операции

int a = 20;
int b = 18;
int c = 19;
bool res = a > b;   // true
res = a >= b;       // false
res = a < b;        // false
res = a <= b;       // false

res = a == b;       // false
res = a != b;       // true

res = a > a && a != b || !(a >= b);
res = a > b && (a > c);
res = a > b && a > c;

#endregion

#endregion