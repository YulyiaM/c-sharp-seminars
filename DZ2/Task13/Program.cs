// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99) Console.WriteLine($"Third digit is {ThirdDigit(number)}");
else Console.WriteLine("No third digit!");
Console.WriteLine();

int ThirdDigit(int num)
{
    while (num >= 1000) num = num / 10;
    return num % 10;
}