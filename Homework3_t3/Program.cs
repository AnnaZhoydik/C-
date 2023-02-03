// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int[] array = { 5, 3, 6, 8, 9, 1 };
int max = 0;
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
    else if (min > array[i])
    {
        min = array[i];
    }
}
Console.Write(max - min);