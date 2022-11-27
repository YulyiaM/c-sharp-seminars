Console.Clear();

Console.WriteLine("Enter the integer N:");
int N = Convert.ToInt32(Console.ReadLine());

int count = -N;
while (count <= N)
{
    Console.Write($"{count} ");
    count++;
}

Console.WriteLine();

Console.WriteLine("Enter the three-digit number:");
int threeDigitN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(threeDigitN % 10);