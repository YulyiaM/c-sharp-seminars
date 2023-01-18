// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of digits in {number} is {SumOfDigits(number)}");

int SumOfDigits(int num)
{
    num = Math.Abs(num);
    int sumOfDigits = 0;
    while (num / 10 > 0)
    {
        sumOfDigits += num % 10;
        num = num / 10;
    }
    return sumOfDigits + num;
}
