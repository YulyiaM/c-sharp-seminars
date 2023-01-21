// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArray(int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(array[i], 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

double MaxElem(double[] array)
{
    int index = 0;
    double maxElem = array[index];
    
    while (index < array.Length)
    {
        if (array[index] > maxElem) maxElem = array[index];
        index++;
    }
    
    return maxElem;
}

double MinElem(double[] array)
{
    int index = 0;
    double minElem = array[index];
    
    while (index < array.Length)
    {
        if (array[index] < minElem) minElem = array[index];
        index++;
    }
    
    return minElem;
}

double[] arr = CreateArray(8, 1, 20);
PrintArray(arr);
double maxInArr = MaxElem(arr);
double minInArr = MinElem(arr);
Console.Write($" -> {maxInArr - minInArr}");
