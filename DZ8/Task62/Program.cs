// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiralMatrix4X4(int fillingValue, int rows, int columns)
{
    int[,] spiralMatrix = new int[rows, columns];

    for (int j = 0; j < columns; j++)
    {
        spiralMatrix[0, j] = fillingValue;
        fillingValue++;
    }

    for (int i = 1; i < rows; i++)
    {
        spiralMatrix[i, columns - 1] = fillingValue;
        fillingValue++;
    }

    for (int j = columns - 2; j >= 0; j--)
    {
        spiralMatrix[rows - 1, j] = fillingValue;
        fillingValue++;
    }

    for (int i = rows - 2; i >= 1; i--)
    {
        spiralMatrix[i, 0] = fillingValue;
        fillingValue++;
    }

    for (int j = 1; j < columns - 1; j++)
    {
        spiralMatrix[1, j] = fillingValue;
        fillingValue++;
    }

    for (int j = columns - 2; j >= 1; j--)
    {
        spiralMatrix[rows - 2, j] = fillingValue;
        fillingValue++; 
    }

    return spiralMatrix;
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

Console.Write("Enter the start number: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
int[,] spirMatrix = CreateSpiralMatrix4X4(startNumber, 4, 4);
if(spirMatrix.GetLength(0) == 4 && spirMatrix.GetLength(1) == 4) PrintMatrix(spirMatrix);
else Console.WriteLine("Incorrect matrix size!");