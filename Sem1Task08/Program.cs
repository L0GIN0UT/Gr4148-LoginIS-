//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");

string? number = Console.ReadLine();

if (number != null)
{

    int num = int.Parse(number);

    int StartNum = 1;

    string res = String.Empty;

    while (StartNum <= num)
    {
        if(StartNum % 2 == 0)
        {
         res = res + StartNum + " "; 
        }
       StartNum = StartNum + 1;
    }
Console.WriteLine(res);
}