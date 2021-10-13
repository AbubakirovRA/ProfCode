using System;
using static System.Console;

/// <summary>
/// Метод сложения трёх чисел
/// </summary>
/// <param name="a">Первое число</param>
/// <param name="b">Второе число</param>
/// <param name="c">Третье число</param>
/// <returns>Сумма</returns>
int Method(int a, int b, int c)
{
    return a + b + c;
}

#region Одна математическая задача 
// Векторное произведение векторов

/// <summary>
/// <para>Векторное произведение двух векторов</para>
/// <para>Вектор A(ax, ay, az)</para>
/// <para>Вектор B(bx, by, bz)</para>
/// </summary>
/// <param name="ax">Абсцисса вектора А</param>
/// <param name="ay">Ордината вектора А</param>
/// <param name="az">Аппликата вектора А</param>
/// <param name="bx">Абсцисса вектора В</param>
/// <param name="by">Ордината вектора В</param>
/// <param name="bz">Аппликата вектора В</param>
void VectorMultiplication1(int ax, int ay, int az, int bx, int by, int bz)
{
    int cx = ay * bz - az * by;
    int cy = az * bx - ax * bz;
    int cz = ax * by - ay * bx;
}

#region VectorMultiplication v1

/// <summary>
/// <para>Векторное произведение двух векторов</para>
/// <para>Вектор A(ax, ay, az)</para>
/// <para>Вектор B(bx, by, bz)</para>
/// <para>Вектор C(cx, cy, cz)</para>
/// </summary>
/// <param name="ax">Абсцисса вектора А</param>
/// <param name="ay">Ордината вектора А</param>
/// <param name="az">Аппликата вектора А</param>
/// <param name="bx">Абсцисса вектора В</param>
/// <param name="by">Ордината вектора В</param>
/// <param name="bz">Аппликата вектора В</param>
/// <param name="cx">Абсцисса вектора C</param>
/// <param name="cy">Ордината вектора C</param>
/// <param name="cz">Аппликата вектора C</param>

void VectorMultiplication2(int ax, int ay, int az,
                               int bx, int by, int bz,
                               int cx, int cy, int cz)
{
    WriteLine($"До: {cx} {cy} {cz}");
    cx = ay * bz - az * by;
    cy = az * bx - ax * bz;
    cz = ax * by - ay * bx;
    WriteLine($"После: {cx} {cy} {cz}");
}

#endregion

#region VectorMultiplication v2

/// <summary>
/// <para>Векторное произведение двух векторов</para>
/// <para>Вектор A(ax, ay, az)</para>
/// <para>Вектор B(bx, by, bz)</para>
/// <para>Вектор C(cx, cy, cz)</para>
/// </summary>
/// <param name="ax">Абсцисса вектора А</param>
/// <param name="ay">Ордината вектора А</param>
/// <param name="az">Аппликата вектора А</param>
/// <param name="bx">Абсцисса вектора В</param>
/// <param name="by">Ордината вектора В</param>
/// <param name="bz">Аппликата вектора В</param>
/// <param name="cx">Абсцисса вектора C</param>
/// <param name="cy">Ордината вектора C</param>
/// <param name="cz">Аппликата вектора C</param>
void VectorMultiplication3(int ax, int ay, int az,
                           int bx, int by, int bz,
                           ref int cx, ref int cy, ref int cz)
{
    cx = ay * bz - az * by;
    cy = az * bx - ax * bz;
    cz = ax * by - ay * bx;
}

#endregion

#endregion

#region Одна математическая задача 

#region VectorMultiplication v1

//int a1 = 1, a2 = 2, a3 = 3, b1 = 4, b2 = 5, b3 = 6, c1 = 0, c2 = 0, c3 = 0;

//WriteLine("До вызова void VectorMultiplication: ");
//WriteLine($"a1 = {a1} a2 = {a2} a3 = {a3}");
//WriteLine($"b1 = {b1} b2 = {b2} b3 = {b3}");
//WriteLine($"c1 = {c1} c2 = {c2} a3 = {c3}");

//VectorMultiplication1(a1, a2, a3, b1, b2, b3, c1, c2, c3);
//WriteLine("\nПосле вызова void VectorMultiplication: ");
//WriteLine($"a1 = {a1} a2 = {a2} a3 = {a3}");
//WriteLine($"b1 = {b1} b2 = {b2} b3 = {b3}");
//WriteLine($"c1 = {c1} c2 = {c2} a3 = {c3}");


//ReadLine();
#endregion

#region VectorMultiplication v2

int a1 = 1, a2 = 2, a3 = 3, b1 = 4, b2 = 5, b3 = 6, c1 = 0, c2 = 0, c3 = 0;

WriteLine("До вызова void VectorMultiplication1: ");
WriteLine($"a1 = {a1} a2 = {a2} a3 = {a3}");
WriteLine($"b1 = {b1} b2 = {b2} b3 = {b3}");
WriteLine($"c1 = {c1} c2 = {c2} a3 = {c3}");

VectorMultiplication3(a1, a2, a3, b1, b2, b3, ref c1, ref c2, ref c3);
WriteLine("\nПосле вызова void VectorMultiplication3: ");
WriteLine($"a1 = {a1} a2 = {a2} a3 = {a3}");
WriteLine($"b1 = {b1} b2 = {b2} b3 = {b3}");
WriteLine($"c1 = {c1} c2 = {c2} a3 = {c3}");

#endregion

#endregion