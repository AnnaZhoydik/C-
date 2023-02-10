// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.Write($"Введите строку: ");
int line = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write($"Введите номер столбика: ");
int column = Convert.ToInt32(Console.ReadLine()) - 1;
int[,] array = new int[4, 8];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
Console.WriteLine();
}
if (line < 0 | line > array.GetLength(0) - 1 | column < 0 | column > array.GetLength(1) - 1)
{
    Console.Write("Такого числа в массиве нет");
}
else
{
    Console.Write($"число {array[line, column]} на этой позиции");
}




