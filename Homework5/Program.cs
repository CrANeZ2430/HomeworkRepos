using System.Text.RegularExpressions;

var regexForBinary = new Regex("[0,1]$");
var regexForDivisionByTwo = new Regex("[0,2,4,6,8]$");

int binaryNumberToEnter;
while (true)
{
    Console.Write("Enter a binary number: ");
    var input = Console.ReadLine()!;

    if (int.TryParse(input, out binaryNumberToEnter) && regexForBinary.IsMatch(input))
        break;
}

var decimalNumber = ConvertBinaryToDecimal(binaryNumberToEnter);
Console.WriteLine($"Your decimal number: {decimalNumber}");
Console.WriteLine($"Ability to divide by 2: {regexForDivisionByTwo.IsMatch(decimalNumber.ToString())}");

int ConvertBinaryToDecimal(int binaryNumber)
{
    var binaryNumberString = binaryNumber.ToString();
    var attempts = binaryNumber.ToString().Length;
    var sum = 0;
    for (var i = 0; i < attempts; i++)
        sum += int.Parse(binaryNumberString[attempts - 1 - i].ToString()) * (int)Math.Pow(2, i);

    return sum;
}
