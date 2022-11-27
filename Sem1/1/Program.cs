// Console.WriteLine("Enter the integer: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int square = num*num;
// //Console.WriteLine("Еhe square of the entered number is " + square);
// Console.WriteLine($"The square of the entered number is {square}");

// if (num > 9)
// {
//     Console.WriteLine("You entered a number greater than 9");
// }
// else
// {
//     Console.WriteLine("You entered a number less than 10");
// }

// while (num <= 25) // Выводит все числа от введенного по 25
// {
//     Console.Write($"{num} ");
//     num ++;
// }

Console.WriteLine("Enter the first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

// if ((num2 == num1 * num1) || (num1 == num2 * num2))
// {
//     Console.WriteLine("Yes, it is");
// }
// else
// {
//     Console.WriteLine("No, it isn't");
// }

// if (num1 == num2 * num2)
// {
//     Console.WriteLine("Yes, num1 is the square of num2");
// }
// else
// {
//     Console.WriteLine("No, num1 isn't the square of num2");
// }

if (num1 == num2 * num2)
{
    Console.WriteLine("Yes, num1 is the square of num2");
}
else if (num2 == num1 * num1)
{
    Console.WriteLine("Yes, num2 is the square of num1");
}
else
{
    Console.WriteLine("There are no squares");
}