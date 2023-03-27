// Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.

Console.WriteLine("Введите числа");

string? num1 = Console.ReadLine();
string? num2 = Console.ReadLine();

if ((num1 != null) && (num2 != null))
{
    int num01 = int.Parse(num1);
    int num02 = int.Parse(num2);

    if (num01 % num02 == 0) 
    {
        Console.WriteLine($"Число {num1} кратно {num2}");
    }
    else
    {
    Console.WriteLine($"Остаток {num01 % num02}");
    }
}


