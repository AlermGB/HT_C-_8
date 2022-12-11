// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CubeMatrixGenerator()
{
    int maxBorder = 99;
    int minBorder = 10;
    int cubeOrder = 2;
    bool done = true;
    int randomIndex = 0;

    int[,,] cubeMatrix = new int[cubeOrder, cubeOrder, cubeOrder];
    int[] arrayForGeneration = new int[maxBorder - minBorder];
    for (int i = minBorder; i < arrayForGeneration.Length; i++)
    {
        arrayForGeneration[i - minBorder] = i;
    }
    for (int i = 0; i < cubeOrder; i++)
    {
        for (int j = 0; j < cubeOrder; j++)
        {
            for (int k = 0; k < cubeOrder; k++)
            {
                while (done)
                {
                    randomIndex = new Random().Next(0, arrayForGeneration.Length);
                    if (arrayForGeneration[randomIndex] != 0)
                    {
                        cubeMatrix[i, j, k] = arrayForGeneration[randomIndex];
                        done = false;
                        arrayForGeneration[randomIndex] = 0;
                    }

                }
                done = true;
            }
        }
    }
    return cubeMatrix;
}

void ShowCubeMatrixByRow(int[,,] cubeMatrix)
{
    for (int i = 0; i < cubeMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < cubeMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < cubeMatrix.GetLength(2); k++)
            {
                Console.Write($"{cubeMatrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] cube = CubeMatrixGenerator();
ShowCubeMatrixByRow(cube);