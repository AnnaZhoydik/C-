// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.Write("Введите кол-во чисел: ");
int sum = 0;
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine()); ;
    if (array[i] > 0)
    {
        sum = sum + 1;
    }
}
Console.Write($"Количество чисел больше нуля: {sum}");
