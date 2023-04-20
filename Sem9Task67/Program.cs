//  Задача 67
// примает на вход число и возвращает сумму числа
// 

Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

int SummEl(int n)
{     
     
    if (n > 0)
    {   
        return n % 10 + SummEl(n / 10);
    }
    else
    {
        return n;
    }
}

int n = ReadData("Введите число: ");
int sum = SummEl(n);
Console.Write(sum);