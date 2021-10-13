using static System.Console;

#region Теория

// Пока (условие продолжения)
//     действие                 | итерация

// while (условие продолжения)
//     Оператор                 | итерация

// Пока (условие продолжения)
// {
//     список действий          | итерация
// }

//while (условие продолжения)
//{
//     Оператор 1               |
//     Оператор 2               | итерация (тело цикла)
//     ...                      |
//     Оператор N               |
//}

#endregion

#region Задача

WriteLine("Вы хотите продолжить? [Y / N]");

char keyCode = ReadKey().KeyChar;

if (keyCode == 'Y')
    WriteLine("\nВы решили продолжить.");
else if (keyCode == 'N')
    WriteLine("\nВы прервали выполнение.");
else
{
    WriteLine("Вы хотите продолжить? [Y / N]");
    keyCode = ReadKey().KeyChar;
    if (keyCode == 'Y')
        WriteLine("\nВы решили продолжить.");
    else if (keyCode == 'N')
        WriteLine("\nВы прервали выполнение.");
    else
    {
        WriteLine("Вы хотите продолжить? [Y / N]");
        keyCode = ReadKey().KeyChar;
        if (keyCode == 'Y')
            WriteLine("\nВы решили продолжить.");
        else if (keyCode == 'N')
            WriteLine("\nВы прервали выполнение.");
        else
        {
            WriteLine("Вы хотите продолжить? [Y / N]");
            keyCode = ReadKey().KeyChar;
            if (keyCode == 'Y')
                WriteLine("\nВы решили продолжить.");
            else if (keyCode == 'N')
                WriteLine("\nВы прервали выполнение.");
            else
            {
                WriteLine("Вы хотите продолжить? [Y / N]");
                keyCode = ReadKey().KeyChar;
                if (keyCode == 'Y')
                    WriteLine("\nВы решили продолжить.");
                else if (keyCode == 'N')
                    WriteLine("\nВы прервали выполнение.");
                else
                {
                    WriteLine("Вы хотите продолжить? [Y / N]");
                    keyCode = ReadKey().KeyChar;
                    if (keyCode == 'Y')
                        WriteLine("\nВы решили продолжить.");
                    else if (keyCode == 'N')
                        WriteLine("\nВы прервали выполнение.");
                    else
                    {

                    }
                }
            }
        }
    }
}

WriteLine("+++++");

#endregion

#region Пример 1

char answer = '-';

while (!(answer != 'N' ^ answer != 'Y'))
{
    WriteLine("\nВы хотите продолжить? [Y / N]");

    answer = ReadKey().KeyChar;

    if (answer == 'Y')
        WriteLine("\nВы решили продолжить.");
    else if (answer == 'N')
        WriteLine("\nВы прервали выполнение.");
}

#region Ввод нужно числа

//int i = 0;
//while (i <= 0)
//{
//    Write("Введите положительное i: ");
//    i = ToInt32(ReadLine());
//}

#endregion

#endregion

#region Пример 2

int count = 4;                // Счётчик цикла

while (count <= 10)             // Пока счётчик меньше или равен 10 выполнять
{
    Write($"{count} ");         // Вывод на экран текущего значения счётчика
    count++;                    // Увеличивать счётчик на 1
}

WriteLine();

#region Замечание

count = 10;                     // Счётчик цикла

while (count > 0)               // Пока счётчик меньше или равен 10 выполнять
{
    Write($"{count} ");         // Вывод на экран текущего значения счётчика
    count--;                    // Увеличивать счётчик на 1
}

WriteLine();

#endregion

#endregion