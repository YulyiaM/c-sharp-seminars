string DecimalToBinary(int decNum)
{
    string result = String.Empty;

    while (decNum > 0)
    {
        result = decNum % 2 + result;
        decNum = decNum / 2;
    }
    
    return result;
    // string reverseResult = String.Empty;
    // for (int i = 0; i < result.Length; i++)
    // {
    //     reverseResult += result[result.Length - i - 1];
    // }
    //  return Convert.ToInt32(reverseResult);
}

Console.WriteLine("Enter the decimal number: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{decimalNumber} is {DecimalToBinary(decimalNumber)} in binary system");

