Console.Write("Enter the first number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the third number: ");
double thirdNumber = Convert.ToDouble(Console.ReadLine());

double max = firstNumber;

if ((secondNumber > max) & (secondNumber > thirdNumber))
{
    max = secondNumber;
}
else if ((thirdNumber > max) & (thirdNumber > secondNumber))
{
    max = thirdNumber;
}

Console.WriteLine($"Max value is {max}");