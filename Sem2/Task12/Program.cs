Console.WriteLine("Enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int remainNumber = firstNumber % secondNumber;

if (remainNumber == 0) Console.WriteLine("The first number is a multiple of the second");
else Console.WriteLine($"The remainder of the division is {remainNumber}");