// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Console.Write($"{matrix[i, j],5}   ");
        }
        Console.WriteLine("]");
    }
}

double[] ColumnAverage(int[,] matrix)
{
    double[] columnAverage = new double[matrix.GetLength(1)];
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double columnSumm = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            columnSumm += matrix[i, j];
        }
        columnAverage[j] = columnSumm / (matrix.GetLength(0));
    }

    return columnAverage;
}

void PrintAverage(double[] columnAverage)
{
    Console.Write("[");
    for (int i = 0; i < columnAverage.Length; i++)
    {
        Console.Write($"{columnAverage[i],5}   ");
    }
    Console.WriteLine("]");
}

int[,] newMatrix = CreateRandomMatrix(4, 7, 0, 10);
PrintMatrix(newMatrix);
Console.WriteLine("The averages in columns are: ");
double[] averages = ColumnAverage(newMatrix);
PrintAverage(averages);

