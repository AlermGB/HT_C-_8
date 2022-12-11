// Задача 61. Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
const int cellWight = 2;

int factorial(int n)
{
    int x = 1;
    for (int i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int c = 0; c <= (n - i); c++)
    {
        Console.Write("  ");
    }
    for (int c = 0; c <= i; c++)
    {
        Console.Write("  ");
        Console.Write($"{factorial(i) / (factorial(c) * factorial(i - c)), cellWight}");
    }
    Console.WriteLine();
}
