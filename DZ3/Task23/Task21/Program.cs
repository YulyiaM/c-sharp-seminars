int FillCoords(string fillCoords)
{
    Console.WriteLine(fillCoords);
    int coords = Convert.ToInt32(Console.ReadLine());
    return coords;
}

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int temp = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2);
    return Math.Sqrt(temp);
}

int xc1 = FillCoords("Enter X1: ");
int yc1 = FillCoords("Enter Y1: ");
int zc1 = FillCoords("Enter Z1: ");

int xc2 = FillCoords("Enter X2: ");
int yc2 = FillCoords("Enter Y2: ");
int zc2 = FillCoords("Enter Z2: ");

double distance = Distance(xc1, yc1, zc1, xc2, yc2, zc2);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Distance = {distanceRound}");