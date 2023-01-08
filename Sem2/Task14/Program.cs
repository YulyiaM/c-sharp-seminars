Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Multiply(number));

bool Multiply(int num)
{
    if (num%7==0 | num%23==0) return true;
    else return false;
}
