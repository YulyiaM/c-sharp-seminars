int[] array = new int[8];
FillArray(array);
PrintArray(array);

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 2);
//     Console.Write(array[i] + " ");
// }

void FillArray(int[] collection)
{
    Random rnd = new Random();
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}