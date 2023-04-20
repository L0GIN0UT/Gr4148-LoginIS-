// Задача №42
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Clear();

int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

string DecToBin(int NewNum)
{
    string res = String.Empty;
    while(NewNum > 0)
    {
        res += NewNum % 2;
        NewNum = NewNum / 2;
    }
    return res;
}

string res = "";
int NewNum = ReadData("Введите число: ");
res=DecToBin(NewNum);
Console.WriteLine(res);


// {
//     Console.WriteLine(msg);
//     int res = int.Parse(Console.ReadLine() ?? ("0"));

//     return res;
// }

// string DecToBin (int num)
// {
// string res = String.Empty;
// while(num>0)
// {
//     res+=num%2;
//     num=num/2;
// }

// return res;
// }

// string res=0;
// int a=  ReadData ("Введите А");
// res=DecToBin(a);
// Console.WriteLine(res);
