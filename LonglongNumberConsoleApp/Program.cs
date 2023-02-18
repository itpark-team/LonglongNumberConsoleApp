using LonglongNumbersLibrary;

LongNumber longNumber1 = new LongNumber("1");
LongNumber longNumber2 = new LongNumber("1");
LongNumber longNumberSum = longNumber1 + longNumber2;

Console.WriteLine($"longNumber1: {longNumber1}");
Console.WriteLine($"longNumber2: {longNumber2}");
Console.WriteLine($"longNumberSum: {longNumberSum}");

if (longNumber1 >= longNumber2)
{
    Console.WriteLine("longNumber1 больше либо равно longNumber2");
}
else
{
    Console.WriteLine("longNumber1 НЕ больше  либо равно longNumber2");
}