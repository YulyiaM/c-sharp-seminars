// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter the amount of numbers: ");
int amountOfNumbers = Convert.ToInt32(Console.ReadLine());

int[] userArray = InputArray(amountOfNumbers);
PrintArray(userArray);
Console.Write($" -> {PositiveCount(userArray)}");

int[] InputArray(int size)
{
    int[] inputArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Enter the {i + 1} number: ");
        inputArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    return inputArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }

    Console.Write(array[array.Length - 1]);
}

int PositiveCount(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }

    return count;
}





