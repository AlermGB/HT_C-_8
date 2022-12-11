// ### Задача 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


int[,] FillMatrixInt(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int newM = 0;
int newN = 0;
int newI = -1;
int newJ = -1;
int[,] mainMatrix = FillMatrixInt(m, n);
bool[] coruptedI = new bool[m];
bool[] coruptedJ = new bool[n];
int min = mainMatrix[0, 0];
int minCounter = 1;


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mainMatrix[i, j] == min)
        {
            minCounter++;
        }
        else if (mainMatrix[i, j] < min)
        {
            min = mainMatrix[i, j];
            minCounter = 1;
        }
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mainMatrix[i, j] == min)
        {
            coruptedI[i] = true;
            coruptedJ[j] = true;
        }
    }
}

for (int i = 0; i < m; i++)
{
    if (!coruptedI[i])
    {
        newM++;
    }
}

for (int i = 0; i < n; i++)
{
    if (!coruptedJ[i])
    {
        newN++;
    }
}

int[,] newMatrix = new int[newM, newN];

if (newM ==0 || newN == 0)
{
    Console.WriteLine("Нового массива не существует ");
}
else
{
    for (int i = 0; i < m; i++)
    {
        if (!coruptedI[i])
        {
            newI++;
            for (int j = 0; j < n; j++)
            {
                if (!coruptedJ[j])
                {
                    newJ++;
                    newMatrix[newI, newJ] = mainMatrix[i, j];
                    
                }
            
            }
            newJ=-1;
        }

    }

    PrintMatrix(newMatrix);
}