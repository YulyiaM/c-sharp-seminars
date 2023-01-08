// // Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

Console.WriteLine("Enter the three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (99 < number && number < 1000) Console.WriteLine($"Second Digit is {SecondDigit(number)}");
else Console.WriteLine("Incorrect number!");

int SecondDigit(int num)
{
    return num / 10 % 10;
}