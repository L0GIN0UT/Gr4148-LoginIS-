//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три разных числа");

string? number1 = Console.ReadLine();
string? number2 = Console.ReadLine();
string? number3 = Console.ReadLine();

if ((number1 != null) && (number2 != null) && (number3 != null))
{
    int num1 = int.Parse(number1);
    int num2 = int.Parse(number2);
    int num3 = int.Parse(number3);

    if (num1 > num2 && num1 > num3)
    {
        Console.WriteLine($"Большее: {num1}");
    }

    if (num2 > num1 && num2 > num3)
    {
        Console.WriteLine($"Большее: {num2}");
    }

    if (num3 > num1 && num3 > num2)
    {
        Console.WriteLine($"Большее: {num3}");
    }
}