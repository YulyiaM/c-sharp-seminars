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

int SumOfOddIndexElements(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i]; //похоже, что компилятор сам знает, что 1 - нечётное, 
    }                                    //так как в консоли эта позиция суммируется   

    return sum;
}

int[] arr = CreateArray(7, -100, 100);
PrintArray(arr);
Console.Write($" -> {SumOfOddIndexElements(arr)}");