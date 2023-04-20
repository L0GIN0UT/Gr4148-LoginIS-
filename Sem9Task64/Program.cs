// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//метод подсчета чисел от n до 1
void NewN(int n)
{   
    if (n < 1)
    {
        return;
    }
    else
    {
        Console.Write(n + " ");
        NewN(n - 1);
    }
}

int n = ReadData("Введите n: ");
NewN(n);
