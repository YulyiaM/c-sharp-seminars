// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int EnteringNotNegativeIntegers(string message)
{
    int result;
    bool parse;
    Console.Write(message);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse || result < 0) result = EnteringNotNegativeIntegers(message);
    return result;
}

int AkkermanFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM > 0 && numN == 0) return AkkermanFunction(numM - 1, 1);
    return AkkermanFunction(numM - 1, AkkermanFunction(numM, numN - 1));
}

int numberM = EnteringNotNegativeIntegers("Enter the natural number M: ");
int numberN = EnteringNotNegativeIntegers("Enter the natural number N: ");

Console.WriteLine(AkkermanFunction(numberM, numberN));