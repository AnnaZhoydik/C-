// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int Func(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Func(n - 1, 1);
    if (n > 0 && m > 0) return Func(n - 1, Func(n, m - 1));
    return Func(n, m);
}
Console.Write($"A(m,n) = {Func(m, n)}");