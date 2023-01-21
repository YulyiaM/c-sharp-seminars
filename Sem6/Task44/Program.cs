Console.WriteLine("Enter the number N: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] fiboNums = FibonacciNumbers(number);
PrintArray(fiboNums);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] FibonacciNumbers(int num)
{
    int[] fibonacciNumbers = new int[num];
    //fibonacciNumbers[0] = 0; по умолчанию так и есть
    fibonacciNumbers[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
    }
    return fibonacciNumbers;
}

