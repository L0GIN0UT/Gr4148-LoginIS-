// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//метод суммы чисел от m до n
int SumMToN(int m, int n)
{   
        if (m <= n)
    {
       return m + SumMToN(m + 1,n);
    }
    else
    {
        return 0;
    }
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
//проверка на дурака
int sum = SumMToN((m>n)?n:m,(m>n)?m:n);
Console.WriteLine(sum);