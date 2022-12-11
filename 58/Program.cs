// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillMatrixInt(int rows, int columns)
{
int[,] matrix = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
matrix[i, j] = new Random().Next(0, 2);
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

Console.WriteLine("Введите размерность первой матрицы l x m:");
Console.Write("Введите l: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите размерность второй матрицы m x n");
Console.Write("Введите m: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (m1 == m2)
{

    int[,] resultMatrix = new int[l, n];

    int[,] aMatrix = FillMatrixInt(l, m1);
    Console.WriteLine();
    int[,] bMatrix = FillMatrixInt(m1, n);
    Console.WriteLine();



    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < m1; k++)
            {
                resultMatrix[i, j] += aMatrix[i, k] * bMatrix[k, j];
            }

        }
    }

    PrintMatrix(resultMatrix);
}
else
{
    Console.Write("Ваши матрицы несовместимы, их невозможно перемножить! ");
}