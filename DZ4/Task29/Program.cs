// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] CreateArray(int size)
{
    int[] collection = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rnd.Next(1, 500);
    }
    return collection;
}

void PrintArray(int[] collection)
{
    string arrayToPrint = String.Join(", ", collection);
    Console.WriteLine($"{arrayToPrint} -> [{arrayToPrint}]");
}

int[] array = CreateArray(8);
PrintArray(array);