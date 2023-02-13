// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int EnteringIntegers(string message)
{
    int result;
    bool parse;
    Console.Write(message);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse) result = EnteringIntegers(message);
    return result;
}

int NaturalNumbersSumm(int numM, int numN)
{
    if (numM == numN) return numM; //не придумала, как корректно вывести сумму при равенстве M и N

    if (numM > numN) return NaturalNumbersSumm(numN, numM);

    return numM + NaturalNumbersSumm(numM + 1, numN);
}

int numberM = EnteringIntegers("Enter the natural number M: ");
int numberN = EnteringIntegers("Enter the natural number N: ");

Console.Write($"Summ = {NaturalNumbersSumm(numberM, numberN)}");