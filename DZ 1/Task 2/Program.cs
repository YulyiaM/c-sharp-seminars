Console.Clear();

Console.Write("Enter the first integer a = ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a second integer different from the first b = ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine($"max = {firstNumber}");
}
else
{
    Console.WriteLine($"max = {secondNumber}");
}