//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два разных числа");

string? number1 = Console.ReadLine();
string? number2 = Console.ReadLine();

if ((number1 != null) && (number2 != null))
{

    int num1 = int.Parse(number1);
    int num2 = int.Parse(number2);

    if (num1 > num2)
    {
        Console.WriteLine($"Большее: {num1}  Меньшее: {num2}");
    }
    else
    Console.WriteLine($"Большее: {num2}  Меньшее: {num1}");

}


