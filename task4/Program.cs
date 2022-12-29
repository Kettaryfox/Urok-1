Console.Write("Введите целое число1: ");

int number1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите целое число2: ");

int number2 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите целое число3: ");

int number3 = int.Parse(Console.ReadLine() ?? "");

if(number1 > number2)
{
    int max = number1;
    if(max > number3)
    {
        Console.WriteLine($"{number1}, {number2}, {number3} -> {max}");
    }
    else
    {
        Console.WriteLine($"{number1}, {number2}, {number3} -> {number3}");
    }
}
else
{
    int max = number2;
    if(max > number3)
    {
        Console.WriteLine($"{number1}, {number2}, {number3} -> {max}");
    }
    else
    {
        Console.WriteLine($"{number1}, {number2}, {number3} -> {number3}");
    }
}
