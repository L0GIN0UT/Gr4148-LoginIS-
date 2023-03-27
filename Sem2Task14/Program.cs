// Задача №14
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число");

string? numberStr = Console.ReadLine();
if (numberStr != null)
{

    int numInt = int.Parse(numberStr);

    if (numInt % 7 == 0 && numInt % 23 == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("Некратно");
    }
}