// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] RowSumm(int[,] matrix)
{
    int[] rowSumm = new int[matrix.GetLength(0)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int currentRowSumm = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            currentRowSumm += matrix[i, j];
        }
        rowSumm[i] = currentRowSumm;
    }

    return rowSumm;
}

void PrintRowSumm(int[] rowSumm)
{
    Console.Write("[");
    for (int i = 0; i < rowSumm.Length; i++)
    {
        Console.Write($"{rowSumm[i],4}  ");
    }
    Console.WriteLine("]");
}

void PrintMinRowNumber(int[] rowSumm)
{
    int minSum = rowSumm[0];
    int minRow = 0;
    for (int i = 1; i < rowSumm.Length; i++)
    {
        if (rowSumm[i] < minSum)
        {
            minSum = rowSumm[i];
            minRow = i;
        }
    }
    Console.WriteLine($"The index of row with min elements summ is: {minRow}");
}

int[,] newMatrix = CreateRandomMatrix(5, 3, 1, 20);
PrintMatrix(newMatrix);
Console.WriteLine();
int[] rowSumms = RowSumm(newMatrix);
PrintRowSumm(rowSumms);
Console.WriteLine();
PrintMinRowNumber(rowSumms);