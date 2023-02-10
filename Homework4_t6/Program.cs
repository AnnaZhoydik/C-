// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m = 2;
int n = 2;
int p = 2;
int q = 2;
int[,] firstArray = { { 2, 4}, { 3, 2} };
int[,] secondArray = { { 3, 4 }, { 3, 3} };
Console.WriteLine("Первая матрица:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(firstArray[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Вторая матрица:");
for (int i = 0; i < p; i++)
{
    for (int j = 0; j < q; j++)
    {
        Console.Write(secondArray[i, j] + " ");
    }
    Console.WriteLine();
}
if (n!=p)
{
    Console.WriteLine("Невозможно перемножить матрицы");
}
else
{
    int[,] c = new int[m, q];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < q; j++)
        {
            c[i, j] = 0;
            for (int k = 0; k < n; k++)
            {
                c[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    Console.WriteLine("После перемножения:");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(c[i, j] + "\t");
        }
        Console.WriteLine();
    }
}