int[] CreateArrayRndInt(int size, int min, int max)
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
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

int[] ArrayInvertion(int[] array)
{
    int[] invertionedArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        invertionedArray[i] = -array[i];
    }
    return invertionedArray;
}

int[] arr = CreateArrayRndInt(4, -9, 9);
PrintArray(arr);
Console.Write(" -> ");
int[] invertionedArr = ArrayInvertion(arr);
PrintArray(invertionedArr);

