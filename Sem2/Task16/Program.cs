Console.WriteLine("Enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Square(firstNumber, secondNumber) ? "Yes" : "No");

// if (secondNumber==firstNumber*firstNumber || firstNumber==secondNumber*secondNumber) Console.WriteLine("Yes");
// else Console.WriteLine("No");

bool Square(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}