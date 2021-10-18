Типы, которые закрывают 80% задач
====================

<text style="font-family:Consolas;"> 
int ещё известен как Int32 [System.Int32]<br>
Диапазон: От -2 147 483 648  до 2 147 483 647<br>
Размер: 32-разрядное целое число со знаком (4 байта)<br>
</text>


<text style="font-family:Consolas;"><br>
double ещё известен как Double [System.Double]<br>
Диапазон: от ±5,0 × 10<sup>−324</sup> до ±1,7 × 10<sup>308</sup><br>
Размер: 64-разрядное число с плавающей запятой(8 байт)
</text>


<text style="font-family:Consolas;"><br>
bool ещё известен как Boolean [System.Boolean]<br>
Диапазон: true и false<br>
Размер: 1 байт
</text><br>


<text style="font-family:Consolas;"><br>
string ещё известен как String [System.String]<br>
Диапазон: от 0 символов до 1 073 741 791 символов<br>
Размер: до 2гб
</text><br>


Больше информации о типах
====================

1. [Общие целые типы](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types) | [C# v.9 nint и nuint](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/nint-nuint)

Начиная с C# 9.0, можно использовать ключевые слова nint и nuint для определения целых чисел собственного размера. Эти целые числа будут 32-разрядными при использовании в 32-битных процессах и 64-разрядными при использовании в 64-битных процессах.

2. [Общие вещественные типы](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types)

3. [System.Boolean](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/bool)

4. [Символы Char](https://docs.microsoft.com/ru-ru/dotnet/api/system.char?view=net-5.0)

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
Методы, заслуживающие отдельного внимания

- [Проверка на принадлежность символа Юникода к категории десятичных цифр Char.IsDigit](https://docs.microsoft.com/ru-ru/dotnet/api/system.char.isdigit?view=net-5.0)

- Относится ли символ к буквам [верхнего регистра Char.IsUpper](https://docs.microsoft.com/ru-ru/dotnet/api/system.char.isupper?view=net-5.0) | [нижнего регистра Char.IsUpper](https://docs.microsoft.com/ru-ru/dotnet/api/system.char.islower?view=net-5.0) 

- [Другие методы](https://docs.microsoft.com/ru-ru/dotnet/api/system.char.compareto?view=net-5.0)


5. [Строки String](https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/strings/) | [Базовый API для работы со строками](https://docs.microsoft.com/ru-ru/dotnet/api/system.string?view=net-5.0#modify-a-string)

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Методы, заслуживающие отдельного внимания
- [Выделение подстроки Substring(Int32, Int32)](https://docs.microsoft.com/ru-ru/dotnet/api/system.string.substring?view=net-5.0#System_String_Substring_System_Int32_System_Int32_)

- [Сцепка элементов массива String.Join](https://docs.microsoft.com/ru-ru/dotnet/api/system.string.join?view=net-5.0)

- [Поиск подстроки String.IndexOf](https://docs.microsoft.com/ru-ru/dotnet/api/system.string.indexof?view=net-5.0)

- [Другие методы](https://docs.microsoft.com/ru-ru/dotnet/api/system.string.clone?view=net-5.0)

6. Продвинутые строки [StringBuilder](https://docs.microsoft.com/ru-ru/dotnet/standard/base-types/stringbuilder)

7. *Типы значений, допускающие значение NULL [Nullable](https://docs.microsoft.com/ru-ru/dotnet/api/system.nullable-1?view=net-5.0)

8. [Кортежи](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/value-tuples)