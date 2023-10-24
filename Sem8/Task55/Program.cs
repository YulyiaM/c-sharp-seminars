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

int[,] TransMatrix(int[,] matrix)
{
    int[,] transMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            transMatrix[i, j] = matrix[j,i];
        }
    }

    return transMatrix;
}

int[,] newMatrix = CreateRandomMatrix(7, 7, 0, 10);
PrintMatrix(newMatrix);

if (newMatrix.GetLength(0) == newMatrix.GetLength(1))
{
Console.WriteLine("The new matrix: ");
int[,] changedMatrix = TransMatrix(newMatrix);
PrintMatrix(changedMatrix);
}
else Console.WriteLine("It's impossible to transpose this matrix!");