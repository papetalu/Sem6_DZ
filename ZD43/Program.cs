﻿// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear(); 
Console.Write("Введите значение k1 для первой прямой: "); 
double k1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите значение b1 для первой прямой: "); 
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2 для второй прямой: "); 
double k2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите значение b2 для второй прямой: "); 
double b2 = Convert.ToInt32(Console.ReadLine());

double x;
double y;

x = (b2 - b1)/ (k1 - k2);
y = k1 * x + b1;
Console.WriteLine(" ");
Console.Write("Координаты точки пересечения прямых: (" + x + ";" + y + ")"); 

