int number = new Random().Next(100, 1000);
Console.WriteLine($"Number = {number}");

int firstDigit = number / 100;
// Console.WriteLine(firstDigit);
int lastDigit = number % 10;
// Console.WriteLine(thirdDigit);

int newNumber = firstDigit * 10 + lastDigit;
Console.WriteLine($"New number = {newNumber}");
