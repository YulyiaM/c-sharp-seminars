// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] randomMatrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            randomMatrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return randomMatrix;
}

void PrintMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}  ");
        }
        Console.WriteLine("]");
    }
}

int[,] MultiMatrix(int[,] aMatrix, int[,] bMatrix)
{
    int[,] multMatrix = new int[aMatrix.GetLength(0), bMatrix.GetLength(1)];
    int[,] tempMatrix = new int[aMatrix.GetLength(0), bMatrix.GetLength(1)];

    for (int k = 0; k < aMatrix.GetLength(1); k++)
    {

        for (int i = 0; i < aMatrix.GetLength(0); i++)
        {
            int currentMultiplier = aMatrix[i, k];
            //Console.WriteLine($"Current mult: {currentMultiplier}"); //для проверки по шагам
            for (int j = 0; j < bMatrix.GetLength(1); j++)
            {
                tempMatrix[i, j] = currentMultiplier * bMatrix[k, j];
            }
        }
        // Console.WriteLine($"Temp{k}: ");             //проверка по шагам 
        // PrintMatrix(tempMatrix);
        // Console.WriteLine();
        multMatrix = MatrixSumm(multMatrix, tempMatrix);
    }
    return multMatrix;
}

int[,] MatrixSumm(int[,] aMatrix, int[,] bMatrix)
{
    int[,] matrixSumm = new int[aMatrix.GetLength(0), aMatrix.GetLength(1)];

    for (int i = 0; i < aMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < aMatrix.GetLength(1); j++)
        {
            matrixSumm[i, j] = aMatrix[i, j] + bMatrix[i, j];
        }
    }
    return matrixSumm;
}


int[,] firstMatrix = CreateRandomMatrix(6, 4, 1, 10);
int[,] secondMatrix = CreateRandomMatrix(4, 3, 1, 10);

PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();

if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{
    int[,] multipliedMatrix = MultiMatrix(firstMatrix, secondMatrix);
    PrintMatrix(multipliedMatrix);
}
else Console.WriteLine("Impossible to multiply!");

