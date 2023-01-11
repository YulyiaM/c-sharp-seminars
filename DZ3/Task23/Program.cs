void Cubes(int num)
{
    int counter = 1;
    while (counter <= num)
    {
        Console.WriteLine($"{counter,7} {counter * counter * counter,7}");
        counter++;
    }
}

Console.WriteLine("Enter the natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 1)
{
    Console.WriteLine("Enter the NATURAL number: ");
    number = Convert.ToInt32(Console.ReadLine());
}

Cubes(number);