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

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}


int[] RowAndColumnMinElem(int[,] matrix)
{
    int[] rowAndColumnMinElem = new int[2];
    int min = matrix[0, 0];
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                rowAndColumnMinElem[0] = i;
                rowAndColumnMinElem[1] = j;
            }
        }
    }
    System.Console.WriteLine(min);// delete after
    return rowAndColumnMinElem;
}

int[,] MatrixWithoutMinCross(int[,] matrix, int[] array)
{
    int newRowsNumber = matrix.GetLength(0) - 1;
    int newColumnsNumber = matrix.GetLength(1) - 1;

    int[,] matrixWithoutMinCross = new int[newRowsNumber, newColumnsNumber];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newRowsNumber; i++)
    {
        if (m == array[0]) m++;
        for (int j = 0; j < newColumnsNumber; j++)
        {
            if (n == array[1]) n++;
            matrixWithoutMinCross[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }

    return matrixWithoutMinCross;
}




int[,] newMatrix = CreateRandomMatrix(4, 4, 0, 50);
PrintMatrix(newMatrix);
Console.WriteLine();
int[] coordMinElem = RowAndColumnMinElem(newMatrix);
PrintArray(coordMinElem);
Console.WriteLine();
int[,] lessMatrix = MatrixWithoutMinCross(newMatrix, coordMinElem);
PrintMatrix(lessMatrix);
