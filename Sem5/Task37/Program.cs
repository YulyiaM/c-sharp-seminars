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

int[] MultArray(int[] array)
{
    int[] multArray = new int[0];
    if (array.Length % 2 == 0) multArray = new int[array.Length / 2];
    else multArray = new int[array.Length / 2 + 1];

    for (int i = 0; i < array.Length / 2; i++)
    {
        multArray[i] = array[i] * array[array.Length - 1 - i];
    }
    
    if (array.Length % 2 != 0) multArray[array.Length / 2] = array[array.Length / 2];
    return multArray;
}


int[] arr = CreateArray(8, 1, 20);
PrintArray(arr);
int[] multArr = MultArray(arr);
Console.Write(" -> ");
PrintArray(multArr);