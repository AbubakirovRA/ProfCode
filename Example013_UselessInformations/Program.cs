using System;
using static System.Console;

#region Вспомогательные операторы


//for (; ; )
//{
//    WriteLine(DateTime.Now);
//    if (DateTime.Now.Second == 35)
//    {
//        WriteLine(DateTime.Now);
//        break;
//    }
//}

#region break
// Оператор break может стоять в теле цикла
// и досрочно завершить ближайший к нему

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

// Иной сценарий
answer = '-';

while (true)
{
    WriteLine("\nВы хотите продолжить? [Y / N]");
    answer = ReadKey().KeyChar;

    if (answer == 'Y')
    {
        WriteLine("\nВы решили продолжить.");
        break;      // Досрочное прерывание
    }
    else if (answer == 'N')
    {
        WriteLine("\nВы прервали выполнение.");
        break;      // Досрочное прерывание
    }
}
#endregion

#region continue
// Оператор continue осуществляет переход к следующей итерации этого цикла.

Write("n = ");
int n = 17;

while (n --> 0)
{
    if (n % 3 == 0) continue;
    Write($"{n} ");
}

#endregion


#endregion