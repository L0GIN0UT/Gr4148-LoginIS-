//Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите числа");

string? num1Str = Console.ReadLine();
string? num2Str = Console.ReadLine();

if ((num1Str != null) && (num2Str != null))
{
    int num1 = int.Parse(num1Str);
    int num2 = int.Parse(num2Str);

    if (num1 * num1 == num2)
    {
        Console.WriteLine($"Число {num2Str} является квадратом числа {num1Str}");
    }
    if (num2 * num2 == num1)
    {
        Console.WriteLine($"Число {num1Str} является квадратом числа {num2Str}");
    }
}


// int num1 = int.Parse(Console.ReadLine()??"0");
// int num2 = int.Parse(Console.ReadLine()??"0");
// void SqrtTest(int a,int b)
// {
//     if(a==b*b)
//     Console.WriteLine(a+" Sqrt "+b);
//     else
//     Console.WriteLine(a+" No Sqrt "+b);

// } 
// SqrtTest(num1,num2 );
// SqrtTest(num2,num1);