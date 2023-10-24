Console.WriteLine("Enter the number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Произведение чисел от 1 до {numN} равно {MultToN(numN)}");

int MultToN(int number)
{
    int mult = 1;
    for (int i = 1; i <= number; i++)
    {
        mult *= i;
    }
    return mult;
}