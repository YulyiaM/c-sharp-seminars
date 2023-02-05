int[,] CreateRandomMatrix(int min, int max, int rows, int columns)
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


int[,] ChangeMatrix(int[,] matrix)
{
    int[,] changedMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) changedMatrix[i, j] = matrix[i, j] * matrix[i, j];
            else changedMatrix[i, j] = matrix[i, j];
        }
    }

    return changedMatrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

int[,] startMatrix = CreateRandomMatrix(-10, 10, 3, 4);
PrintMatrix(startMatrix);
Console.WriteLine();
int[,] resultMatrix = ChangeMatrix(startMatrix);
PrintMatrix(resultMatrix);