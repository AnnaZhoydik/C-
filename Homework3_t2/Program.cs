// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// нечётные в массиве:

int[] array = { 5, 3, 6, 8, 9, -4 };
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
    {
        sum = sum + array[i];
    }
}
Console.Write(sum);

// нечётные по визуальной позиции(если смотреть как пользователь):

// int[] array = { 5, 3, 6, 8, 9, -4 };
// int sum = array[0];
// for (int i = 1; i < array.Length; i++)
// {
//     if (i % 2 == 0)
//     {
//         sum = sum + array[i];
//     }
// }
// Console.Write(sum);