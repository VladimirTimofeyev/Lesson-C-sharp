﻿/*
21. Напишите программу которая принимает на вход координаты двух точек в виде массива
 целых чисел и возвращает расстояние между ними в 3D пространстве.
 A (3,6,8); B (2,1,-7) -> 15.84
 A (7,-5,0); B (1,-1,9) -> 11.53
*/

Console.Clear();
Console.Write("Введите координаты A(X): ");
int coorAx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты A(Y): ");
int coorAy = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты A(Z): ");
int coorAz = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты B(X): ");
int coorBx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты B(Y): ");
int coorBy = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты B(Z): ");
int coorBz = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Координаты A: [{coorAx}]:[{coorAy}]:[{coorAz}]");
System.Console.WriteLine($"Координаты B: [{coorBx}]:[{coorBy}]:[{coorBz}]");


double resalt = Math.Sqrt(Math.Pow((coorBx - coorAx), 2) + Math.Pow((coorBy - coorAy), 2) + Math.Pow((coorBz - coorAz), 2));
System.Console.WriteLine("Расстояние между точками; " + Math.Round(resalt, 2));