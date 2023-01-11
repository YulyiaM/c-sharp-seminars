Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

string range = QuarterCoord(num);
Console.WriteLine(range);

string QuarterCoord(int number)
{
    if (number == 1) return "Диапазон координат: x > 0, y > 0";
    if (number == 2) return "Диапазон координат: x < 0, y > 0";
    if (number == 3) return "Диапазон координат: x < 0, y < 0";
    if (number == 4) return "Диапазон координат: x > 0, y < 0";
    return "Введены некорректные данные";
} 