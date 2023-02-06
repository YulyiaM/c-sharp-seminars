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

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[index] = matrix[i, j];
            index++;
        }
    }
    return array;
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


int[,] FreqDictionary(int[] array)
{
    int[,] freqDictionary = new int[array.Length, 2];
    int currentValue = array[0];
    freqDictionary[0, 0] = currentValue;
    freqDictionary[0, 1] = 1;
    int count = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currentValue)
            freqDictionary[count, 1]++;
        else
        {
            count++;
            currentValue = array[i];
            freqDictionary[count, 0] = array[i];
            freqDictionary[count, 1]++;
        }

    }
    return freqDictionary;
}

int[,] ZeroDeleter(int[,] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if(matrix[i,1] == 0) count++;
    }
    int newLength = matrix.GetLength(0)-count;
    int[,] matrixWithoutZero = new int[newLength,2];
    for (int i = 0; i < newLength; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            matrixWithoutZero[i,j] = matrix[i,j];
        }
    }
    return matrixWithoutZero;
}



int[,] newMatrix = CreateRandomMatrix(3, 3, 0, 10);
PrintMatrix(newMatrix);
int[] newArray = MatrixToArray(newMatrix);
PrintArray(newArray);

Array.Sort(newArray);
PrintArray(newArray);

int[,] finalDictionary = FreqDictionary(newArray);
PrintMatrix(finalDictionary);
Console.WriteLine();
int[,] finalDictionaryWithoutZero = ZeroDeleter(finalDictionary);
PrintMatrix(finalDictionaryWithoutZero);