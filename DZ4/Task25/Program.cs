// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Enter the number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Exponentiation(numberA, numberB));

string Exponentiation(int numA, int numB)
{
    if (numB > 0 && numB % 1 == 0) //хотя второе условие очевидно для типа int
    {
        int exponentiatedA = 1;
        for(int i = 0; i < numB; i++) exponentiatedA *= numA;
        return $"{numA} ^ {numB} = {exponentiatedA}";
    }
    else return $"{numB} is not natural number!";
}
