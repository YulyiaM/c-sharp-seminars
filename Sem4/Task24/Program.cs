Console.WriteLine("Enter the number A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от 1 до {numA} равна {SumToA(numA)}");

int SumToA(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}
