// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Enter the number from 1 to 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8) Console.WriteLine(IfDayOff(number) ? "Yes, the day is off" : "No, it is working day");
else Console.WriteLine("Incorrect number!");

Console.WriteLine();

bool IfDayOff(int num)
{
    return num == 6 || num == 7;
}