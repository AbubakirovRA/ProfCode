using static System.Console;

#region Пример 1

int count = 158;                // Счётчик цикла

do                              // Делай
{
    Write($"{count} ");         // Вывод на экран текущего значения счётчика
    count++;                    // Увеличивать счётчик на 1
}
while (count <= 10);            // Пока счётчик меньше или равен 10

WriteLine();

#endregion