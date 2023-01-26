// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]


int[] array = new int[8];
Random number = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = number.Next(0, 200);
    Console.Write($"{array[i]} ");
}
