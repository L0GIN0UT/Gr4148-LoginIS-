// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//Метод Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }
}

int m = ReadData("Введите положительное m: ");
int n = ReadData("Введите положительное n: ");
//Проверка на дурака
if (m < 0)
{
    m = Math.Abs(m);
}
if (n < 0)
{
    n = Math.Abs(n);
}
int res = Akkerman(m, n);
Console.WriteLine(res);