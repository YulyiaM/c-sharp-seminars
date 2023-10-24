int PowerAToB(int numberA, int numberB)
{
    if (numberB == 0) return 1;
    return PowerAToB(numberA, numberB - 1) * numberA;
}

Console.WriteLine("Enter the numbers: ");
Console.Write("A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PowerAToB(numA, numB));