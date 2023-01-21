bool CanTriangleBe(int aSide, int bSide, int cSide)
{
    return aSide < bSide + cSide && bSide < aSide + cSide && cSide < aSide + bSide;
}

Console.WriteLine("Enter the side lengths ");
Console.Write("side A: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.Write("side B: ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.Write("side C: ");
int sideC = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(CanTriangleBe(sideA,sideB,sideC) ? "Yes, it can be" : "No, it cannot be");