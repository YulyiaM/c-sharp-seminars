// *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] Create3DMatrix(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix3D = new int[rows, columns, depth];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                matrix3D[i, j, k] = min;
                min++;
            }
        }
    }
    return matrix3D;
}

void Print3DMatrix(int[,,] matrix3D)

{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"{matrix3D[i,j,k]}({i},{j},{k}) ");
            }
        }
       Console.WriteLine();
    }
}

int[,,] newMatrix3D = Create3DMatrix(4,2,7,10,99);
if (newMatrix3D.GetLength(0)*newMatrix3D.GetLength(1)*newMatrix3D.GetLength(2) < 100)
Print3DMatrix(newMatrix3D);
else Console.WriteLine("Not enough two-digit numbers without repetition");