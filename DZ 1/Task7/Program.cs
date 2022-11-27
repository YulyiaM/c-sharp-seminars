Console.Write("Enter the integer: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = 0;

if (number / 100 == 0)
{
    Console.WriteLine("There is no third digit from left");
}

else
{
    while (number >= 1000)
    {
        number /= 10;
    }
    thirdDigit = number % 10;
    Console.WriteLine("The third digit from left is: " + thirdDigit);
}