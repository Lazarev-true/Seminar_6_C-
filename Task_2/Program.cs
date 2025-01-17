﻿// Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения 
// b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());

double x, y;
if(k1 == k2 && b1 == b2) { Console.WriteLine("Прямые совпадают"); }
else if (k1 == k2) { Console.WriteLine("Прямые параллельны"); }
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}
