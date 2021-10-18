Теория
===
Неполное ветвление
---
```
ЕСЛИ (условие)
    Оператор 1    | Выполняется, если условие "ИСТИНА"
```
Неполное ветвление и составной оператор
---
```
ЕСЛИ (условие)
{
    Оператор 1    | Выполняется, если условие "ИСТИНА"
    Оператор 2    |
    ...           |
    Оператор N    |
}
```
Полное ветвление
---
```
ЕСЛИ (условие)
    Оператор 1    | Выполняется, если условие "ИСТИНА"
ИНАЧЕ
    Оператор 2    | Выполняется, если условие "ЛОЖЬ"
```
Полное ветвление и составной оператор
---
```
ЕСЛИ (условие)
{
    Оператор 1    |
    Оператор 2    | Выполняется, если условие "ИСТИНА"
    ...           | 
    Оператор N    |
}
ИНАЧЕ
{
    Оператор N + 1     |
    Оператор N + 2     | Выполняется, если условие "ЛОЖЬ"
    ...                |
    Оператор N+M       |
}
```

Найти общую часть двух отрезков
===
```
int x1 = 1, y1 = 8, x2 = 3, y2 = 5; //Исходные данные
WriteLine($"Исходные отрезки: [{x1}; {y1}], [{x2}; {y2}]");

if (x1 < x2) { x1 = x2; }    // Большее из начал
if (y1 > y2) { y1 = y2; }    // Меньший из концов
if (x1 > y1) { WriteLine("Не пересекаются"); }     // Ответ
else { WriteLine($"Результат: [{x1}; {y1}]"); }    // 
```

Вложенное ветвление
===
Назвать возраст человека
---
```
int age = 231;  //Исходные данные

Write($"Возрвст: {age}");

int t = age % 100;              // Последние две цифры
if (t / 10 == 1) { t = 0; }     // 1 десяток равносилен 0
t = t % 10;                     // Последняя цифра
if (t == 0 || t > 4)            // Если 0, 5, 6, 7, 8, 9, то
{ WriteLine(" Лет"); }          // Лет
else                            // Иначе
{
    if (t == 1) { WriteLine(" Год"); } // Если 1, то Год
    else { WriteLine(" ГОДА"); }       // Иначе Года
}
ReadLine();
```

Сложно?
===
Написать простой калькулятор
---
```
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

double result = 0;
if (operation == "/") result = x / y / z;
if (operation == "*") result = x * y * z;
if (operation == "+") result = x + y + z;
if (operation == "-") result = x - y - z;
if (operation == "^") result = Math.Pow(x, Math.Pow(y,z));

WriteLine($"result = {result}");
```
Как улучшить
---

```
Write("Введите первое число: ");
string input = Console.ReadLine();
double x = double.Parse(input);
```
Заменить на

```
Write("Введите число: ");
double x;
while (!double.TryParse(Console.ReadLine(), out x)) ;
```
```
Write("Введите первое число: ");
double x;
for (; !double.TryParse(Console.ReadLine(), out x);) ;
```
и
```
double result = 0;
if (operation == "/") result = x / y / z;
if (operation == "*") result = x * y * z;
if (operation == "+") result = x + y + z;
if (operation == "-") result = x - y - z;
if (operation == "^") result = Math.Pow(x, Math.Pow(y,z));
```
Заменить на
```
double result = operation switch
{
    "/" => x / y / z,
    "*" => x * y * z,
    "-" => x - y - z,
    "+" => x + y + z,
    _ => Math.Pow(Math.Pow(x, y), z)
};
```