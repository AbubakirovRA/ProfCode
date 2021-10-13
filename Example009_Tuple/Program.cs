using System;
using static System.Console;

//Tuple<string, int> user = new Tuple<string, int>("Sergei", 31);

(string, int) user = ("Sergei", 31);
WriteLine($"{user.Item1} {user.Item2}");


(int x, int y) point = (9, 28);
WriteLine($"x: {point.x} y:{point.y}");

(string name, int age, double scholarship) student = ("Jane", 32, 10.83);
WriteLine($"{student.name} {student.age} {student.scholarship}");

var worker = (Name: "Tom", Age: 33, Salary: 1.3);
WriteLine($"{worker.Name} {worker.Age} {worker.Salary}");

// деконструкция кортежей
(string n, int a, double d) = worker;
WriteLine($"n = {n}");
WriteLine($"a = {a}");
WriteLine($"d = {d}");


(string, double) v = ("строка", 1.2);
(int, (string, double)) t = (1, v);

// Tuple<char, Tuple<int, Tuple<string, double>>> val ...
(char, (int, (string, double))) val = ('n', t);
WriteLine($"v = {v}");
WriteLine($"t = {t}");
WriteLine($"val = {val}");