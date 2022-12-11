// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

bool changeStatus = true;
int temp = 0;


Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] mainMatrix = FillMatrixInt(m, n);
for (int rowNow = 0; rowNow < mainMatrix.GetLength(0); rowNow++)
{
    while (changeStatus == true)
    {
        changeStatus = false;
        for (int i = 0; i < mainMatrix.GetLength(1) - 1; i++)
        {

            if (mainMatrix[rowNow, i] < mainMatrix[rowNow, i + 1])
            {
                temp = mainMatrix[rowNow, i];
                mainMatrix[rowNow, i] = mainMatrix[rowNow, i + 1];
                mainMatrix[rowNow, i + 1] = temp;
                changeStatus = true;
            }
        }
    }
    changeStatus = true;
}
PrintMatrix(mainMatrix);