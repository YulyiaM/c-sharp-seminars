// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double k11 = CoefficientsInput("Enter the coefficient", "k1");
double b11 = CoefficientsInput("Enter the coefficient", "b1");
double k22 = CoefficientsInput("Enter the coefficient", "k2");
double b22 = CoefficientsInput("Enter the coefficient", "b2");

double[] crossPointCoords = CrossPoint(k11, b11, k22, b22);
ShowCoords(crossPointCoords);

double CoefficientsInput(string asking, string coefName)
{
    Console.Write($"{asking} {coefName}: ");
    double coefficient = Convert.ToDouble(Console.ReadLine());
    return coefficient;
}

double[] CrossPoint(double k1, double b1, double k2, double b2)
{
    double[] crossPoint = new double[2];
    //k1*x + b1 = k2*x +b2
    //x(k1 - k2) = b2 - b1
    //x = (b2 - b1)/(k1 - k2)
    //y = k1*(b2 - b1)/(k1 - k2) + b1
    crossPoint[0] = (b2 - b1) / (k1 - k2);
    crossPoint[1] = k1 * (b2 - b1) / (k1 - k2) + b1;
    return crossPoint;
}

void ShowCoords(double[] array)
{
    Console.Write("(" + Math.Round(array[0], 1) + "; ");
    Console.WriteLine(Math.Round(array[1], 1) + ")");
}
