// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите число k1: ");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b1: ");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
float k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2: ");
float b2 = Convert.ToInt32(Console.ReadLine());
float x1 = b1 - b2;
float x2 = k2 - k1;
float x = x1 / x2;
float y = k2 * x + b2;
Console.Write($"({x}; {y})");







