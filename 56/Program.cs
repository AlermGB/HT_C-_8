// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] FillMatrixInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}


Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] mainMatrix = FillMatrixInt(m, n);
int[] arrayOfSums = new int[mainMatrix.GetLength(0)];

for (int i = 0; i < mainMatrix.GetLength(0); i++)
{
    for (int j = 0; j < mainMatrix.GetLength(1); j++)
    {
        arrayOfSums[i] += mainMatrix[i, j];
    }
}

int min = arrayOfSums[0];
for (int i = 1; i < arrayOfSums.Length; i++)
{
    if (arrayOfSums[i] < min)
    {
        min = arrayOfSums[i];
    }
}

Console.WriteLine("Наименьшая сумма элементов в строке равна:" + min + ", она соответсвует");

for (int i = 0; i < arrayOfSums.Length; i++)
{
    if (arrayOfSums[i] == min)
    {
        Console.Write("строке №" + (i + 1) + " ");
    }
}



