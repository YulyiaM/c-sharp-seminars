Console.WriteLine("Введите координаты точки1");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки2");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double res = Distance(x1,y1,x2,y2);
double resRound = Math.Round(res,2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками = {Distance(resround)}");

double Distance(int xc1, int yc1, int xc2, int yc2);
{
    int temp = (xc1 - xc2)(xc1 - xc2) + (yc1 - yc2)(yc1 - yc2);
    return Math.Sqrt(temp);
}