int[,] CreateRandomArray(int min, int max, int rows, int columns)
{
    Random rnd = new Random();
    int[,] randomArray = new int[rows, columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            randomArray[i, j] = rnd.Next(min, max + 1);
        }
    }

    return randomArray;
}

void PrintArray(int[,] arr)
{    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 4} ");
        }
        Console.WriteLine("]");
    }
}

int[,] resultArray = CreateRandomArray(-100, 100, 3, 4);
PrintArray(resultArray);
