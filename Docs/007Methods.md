Методы C# [Подпрограмма]
====================

## Что такое метод
- вспомогательный блок кода (оператор), разработанный программистом
- имеет идентификатор (имя)
- может иметь входные и выходные аргументы
- является частью класса, структуры или записи
- методы могут быть вложенными

## Как описывается метод
- !опционально модификаторы: 
    - public, private, protected, ...
    - implicit, explicit 
    - static 
    - operator 
    - и др.
- указывается тип, значение которого возвращает метод 
    - int, string, ...
    - (double, byte)
    - пользовательские типы
    - void
- затем имя которое программист выбирает самостоятельно
- !опционально указываются обобщения в угловых скобках <> 
- если необходимо добавляются аргументы (в круглых скобках),
у аргументов могут содержаться модификаторы
    - ref, out, in
    - params
    - this

- затем идёт тело метода в фигурных скобках { }
    - для void-методов return необязателен
    - для не void-методов return обязателен

- При описании метода, аргументы принято называть "формальными", при вызове - "фактическими"
- Аргументы могут иметь значения по умолчанию

## Пример 1
```
void SystemPause()
{
    ReadKey();
}
```
```
void SystemPause() => ReadKey();
```

## Пример 2.1
```
void SayText(byte count)
{
    for (int i = 0; i < count; i++)
    {
        WriteLine("Привет, Мир!");
    }
}
```

## Пример 2.2
```
void PrintText(string message, byte count)
{
    for (int i = 0; i < count; i++)
    {
        WriteLine(message);
    }
}
```

## Пример 3.1
```
string SayTextCount()
{
    return "Привет, Мир!";
}
```
```
string SayTextCount() => "Привет, Мир!";
```
## Пример 3.2
```
(string, int) SayTextCount()
{
    return ("Привет, Мир!", 2021);
}
```
```
(string, int) SayTextCount() => ("Привет, Мир!", 2021);
```
## Пример 3.3
```
double Pi()
{
    return 3.14159265;
}
```
```
double Pi() => 3.14159265;
```

## Пример 4.1
```
bool IsEven(int n)
{
    return n % 2 == 0;
}
```
```
bool IsEven(int n) => n % 2 == 0;
```
## Пример 4.2
```
string SayTextCount2(byte count)
{
    string msg = string.Empty;

    for (int i = 0; i < count; i++)
    {
        msg += "Привет, Мир! ";
    }
    return msg;
}
```
## Пример 5
```
void SetYear(ref int year)
{
    year = 1990;
}
```

```
void SetYear(ref int year, out int day)
{
    // year = 1990;
    day = 28;
}
```

```
void SetYear(in int year)
{
    // year = 1990; // Error CS8331 'in int' readonly variable
}
```

## Пример 6
```
public static void Sum(this int arg, int value)
{
    arg += value;
}

int v = 20;
2001.Sum(20);
```

## Пример 7
```
double Fibonacci(int n, double a = 0, double b = 1)
{
    if (n > 0) return Fibonacci(n - 1, b, a + b);
    else if (n == -1 && a + b == 1) return 0;
    else return b;
}
for (int i = 0; i < 70; i++) WriteLine(Fibonacci(i));
```

