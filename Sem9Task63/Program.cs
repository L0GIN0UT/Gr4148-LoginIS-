// Задача 63
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

void NewN(int n)
{   
    if (n > 1)
    {
        Console.Write(n + " ");
        NewN(n - 1);
    }
    else
    {
        return;
    }
}

int n = ReadData("Введите n: ");
NewN(n);