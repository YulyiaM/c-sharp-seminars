int DigitsSumm(int number)
{
    if (number == 0) return 0; // if (Math.Abs(number) < 10) return Math.Abs(number); так некорректно работает с отрицательными, непонятно
    else return DigitsSumm(number / 10) + number % 10 ;
}

Console.WriteLine("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DigitsSumm(num));

// int DigitsSumm(int number)
// {
//     int summ = number % 10;
//     while (number > 1)
//     {
//         summ += (number / 10) % 10;
//     }
//     return summ;
// }
// Console.WriteLine(DigitsSumm(1234));