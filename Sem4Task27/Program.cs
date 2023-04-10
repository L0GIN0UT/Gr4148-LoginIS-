// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();

long ReadData(string msg)
{
    Console.Write(msg);
    long res = long.Parse(Console.ReadLine() ?? "0");
    return res;
}
//Подсчет кол-ва цифр
long Length(long Num)
{
    long res = 0;
    while (0 < Num)
    {
        res++;
        Num = Num/10;
    }
    return res;
}
//Суммирование
long NumSumm(long ValN, long Num)
{
    long res = 0;
    for(int i = 0; i <= ValN; i++)
    {
        res += Num%10;
        Num = Num/10;
    }
    return res;
}

long numN = ReadData("Введите число: ");
long ValN = Length(numN);
long Answer = NumSumm(ValN, numN);
Console.WriteLine(Answer);