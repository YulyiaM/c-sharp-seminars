// моя версия:

// Console.WriteLine("Enter the X coordinate: ");
// int coordX = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the Y coordinate: ");
// int coordY = Convert.ToInt32(Console.ReadLine());

// if(coordX!=0 && coordY!=0) Console.WriteLine($"{Quarter(coordX,coordY)} quarter"); 
// else Console.WriteLine("Axis coordinates!");

// int Quarter(int x, int y)
// {
//     int quarter = 0;
//     if (x > 0 && y > 0) quarter = 1;
//     else if (x < 0 && y > 0) quarter = 2;
//     else if (x < 0 && y < 0) quarter = 3;
//     else quarter = 4;
//     return quarter;
// }

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x, y);
string result = quarter > 0 
            ? $"Указанные координаты соответствуют четверти {quarter}"
            : "Введены некорректные данные";

Console.WriteLine(result);

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
} 