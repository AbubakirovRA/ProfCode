Теория
===
```
for (инициализация счётчика; условие (с участием счётчика); выражение (с участием счётчика))
    оператор                 | итерация

Общая модель
for(инициализаторы; условие; список_выражений) 
{
    операторы
}
```
Вывод чисел от 1 до заданного
===
```
for (int count = 1; count <= 10; count++)
{
    Write($"{count} "); // Вывод на экран текущего значения счётчика
}
```

Вывести латинский алфавит
===
```
for (char c = 'A'; c <= 'Z'; c++)
{
    Write($"{c} ");
}
```
Вывести все делители целого числа n
===

```
Write("n = ");
int n = int.Parse(ReadLine());

// ? for (int i = 1; i <= Math.Abs(n) ; i++)
for (int i = 1; i <= n ; i++)
{
    if (n % i == 0) Write($"{i} ");
}
```

Проверить является ли число простым
===

Вариант 1
---
```
Write("n >= 2, n = ");
int n = int.Parse(ReadLine());

string result = "ДА";

for (int i = 2; i <= Math.Sqrt(n); i++)
{
    if (result == "ДА")
    {
        if (n % i == 0)  //Если n делится на i
        { result = "НЕТ"; }
    }
}

WriteLine(result);
```

Вариант 2
---
```
Write("n >= 2, n = ");
int n = int.Parse(ReadLine());

string result = "ДА";

for (int i = 2; i <= Math.Sqrt(n); i++)
{
    if (n % i == 0)  //Если n делится на i
    {
        result = "НЕТ";
        break;
    }
}

WriteLine(result);
```

Вариант 3
---
```
Write("n >= 2, n = ");
int n = int.Parse(ReadLine());

string result = "ДА";

for (int i = 2; i <= Math.Sqrt(n); i++)
{
    if (result == "НЕТ") continue;
    if (n % i == 0)  //Если n делится на i
    { result = "НЕТ"; }
}

WriteLine(result);
```
Выяснить верно ли тождество <br>
<text style="font-family:Consolas;">
1<sup>3</sup>+2<sup>3</sup>+3<sup>3</sup>+...+N<sup>3</sup> = (1+2+3+...+ N)<sup>2</sup> 
</text>
===
Решение в лоб 
-------------------------------
```
Write("n >= 1, n = ");
int n = int.Parse(ReadLine());

double sumLeft = 0;
double sumRight = 0;

for (int i = 1; i <= n; i++)
{
    sumLeft += i * i * i; 
    sumRight += i; 
}

sumRight *= sumRight;
WriteLine(sumLeft == sumRight);
```
Решение, если подумать
-------------------------------
```
Write("n >= 1, n = ");
int n = int.Parse(ReadLine());

string result = "да";
double sum = 0;

for (int i = 1; i <= n; i++)
{
    sum = sum + i * i * i;
    if (4 * sum != Math.Pow((i * (i + 1)),2)) result = "нет"; 
}

WriteLine($"{result}");
```