// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


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
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

int[] InputElemIndexes()
{
    int[] elemIndexes = new int[2];
    Console.WriteLine("Enter the row index: ");
    elemIndexes[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the column index: ");
    elemIndexes[1] = Convert.ToInt32(Console.ReadLine());
    return elemIndexes;
}

void IsIndexInMatrix(int[,] matrix, int[] indexes)
{
    if (indexes[0] < matrix.GetLength(0) && indexes[1] < matrix.GetLength(1))
        Console.WriteLine($"({indexes[0]}, {indexes[1]}) -> {matrix[indexes[0], indexes[1]]}");
    else Console.WriteLine($"({indexes[0]}, {indexes[1]}) -> There in no such index in matrix");
}

int[,] newMatrix = CreateRandomMatrix(4, 7, -50, 50);
PrintMatrix(newMatrix);
Console.WriteLine();
int[] indexesArray = InputElemIndexes();
IsIndexInMatrix(newMatrix, indexesArray);

