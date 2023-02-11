// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortMartixRowsDown(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1 - j; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
    }
}

    int[,] newMatrix = CreateRandomMatrix(8, 7, 0, 10);
    PrintMatrix(newMatrix);
    Console.WriteLine();
    SortMartixRowsDown(newMatrix);
    PrintMatrix(newMatrix);
