// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
const int cellWight = 3;

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],cellWight}");
        }
        Console.WriteLine();
    }
}

int element = 1;
int orderX = 4;
int orderY = 4;
int finalElement = orderX * orderY;
int turnCounter = 0;
int indentCounter = 0;

int[,] spiralMatrix = new int[orderY, orderX];


while (element <= finalElement)
{

    for (int i = 0; i < orderX - turnCounter; i++)
    {
        spiralMatrix[indentCounter, indentCounter + i] = element;
        element++;
    }
    if (element > finalElement)
    {
        break;
    }

    indentCounter++;
    turnCounter++;
    for (int i = 0; i < orderY - turnCounter; i++)
    {
        spiralMatrix[i + indentCounter, orderX - indentCounter] = element;
        element++;
    }
    if (element > finalElement)
    {
        break;
    }
    for (int i = 0; i < orderX - turnCounter; i++)
    {
        spiralMatrix[orderY - indentCounter, orderX - indentCounter - i - 1] = element;
        element++;

    }
    if (element > finalElement)
    {
        break;
    }
    turnCounter++;
    for (int i = 0; i < orderY - turnCounter; i++)
    {
        spiralMatrix[orderY - indentCounter - i - 1, indentCounter - 1] = element;
        element++;
    }
    if (element > finalElement)
    {
        break;
    }

}

PrintMatrix(spiralMatrix);

