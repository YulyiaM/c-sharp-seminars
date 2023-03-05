string[] CreateArray(int size)
{
    string[] userArray = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter the {i + 1} element: ");
        userArray[i] = Console.ReadLine()!;
    }
    return userArray;
}

void PrintArray(string[] userArray)
{
    Console.Write("[");
    if (userArray.Length != 0)
    {
        for (int i = 0; i < userArray.Length - 1; i++)
        {
            Console.Write(userArray[i] + ", ");
        }
        Console.Write(userArray[userArray.Length - 1]);
    }
    Console.Write("]");
}


string[] CutArray(string[] userArray, int strLgth)
{
    string[] cutArray = new string[userArray.Length];
    int cutArraySize = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length < strLgth || userArray[i].Length == strLgth)
        {
            cutArray[cutArraySize] = userArray[i];
            cutArraySize++;
        }
    }
    Array.Resize(ref cutArray, cutArraySize);
    return cutArray;
}
string[] array = CreateArray(5);
string[] newArray = CutArray(array, 3);
PrintArray(array);
Console.Write(" -> ");
PrintArray(newArray);

