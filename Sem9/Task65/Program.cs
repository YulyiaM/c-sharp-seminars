Console.WriteLine("Enter the natural numbers");
Console.Write("N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(numberN, numberM);

void NaturalNumbers(int numN, int numM)
{
    if (numN == numM)
    {
        Console.Write($"{numN} ");
        return;
    }

    if (numN > numM)
        NaturalNumbers(numN - 1, numM);
    else
        NaturalNumbers(numN + 1, numM);
    Console.Write($"{numN} ");
}
