Console.WriteLine("Enter the X coordinate: ");
int coordX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the Y coordinate: ");
int coordY = Convert.ToInt32(Console.ReadLine());

if(coordX!=0 && coordY!=0) Console.WriteLine($"{Quarter(coordX,coordY)} quarter"); 
else Console.WriteLine("Axis coordinates!");

int Quarter(int x, int y)
{
    int quarter = 0;
    if (x > 0 && y > 0) quarter = 1;
    else if (x < 0 && y > 0) quarter = 2;
    else if (x < 0 && y < 0) quarter = 3;
    else quarter = 4;
    return quarter;
}