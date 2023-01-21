int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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
    Console.Write("]");
}

int CountInSegment(int[] array, int minValue, int maxValue)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= minValue && array[i] <= maxValue + 1) count++;
    }
    return count;
}

int[] arr = CreateArray(123, 0, 200);
PrintArray(arr);
Console.WriteLine($" -> {CountInSegment(arr, 10, 99)}");