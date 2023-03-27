// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите 3 значное число");

string? numStr = Console.ReadLine();

if(numStr != null)
{
    int numInt = int.Parse(numStr);

    Console.WriteLine((numInt/10)%10);  
}
