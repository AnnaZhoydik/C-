// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int revNumber_1 = 0;
int revNumber_2 = 0;
int userNumber = number;
if (number >= 10000 && number < 100000)
{
    while (number > 0)
    {
        revNumber_1 = number % 10;
        revNumber_2 = revNumber_2 * 10 + revNumber_1;
        number = number / 10;
    }
    if (userNumber == revNumber_2)
    {
        Console.WriteLine("Число является паллиндромным.");
    }
    else

        Console.WriteLine("Число не является паллиндромным.");

}

else
{
    Console.WriteLine("Введено неверное число.");
}

