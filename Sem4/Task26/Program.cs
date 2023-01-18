Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Quantity of digits in {number} is {QuantityOfDigits(number)}");

int QuantityOfDigits(int num)
{
    //num = Math.Abs(num);
    int quantityOfDigits = 1;
    while (num / 10 != 0)
    {
        num = num / 10;
        quantityOfDigits++;
    }
    return quantityOfDigits;
}
