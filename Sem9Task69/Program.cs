//#69 Напишите прграмму, которая будет принимать 2 числа А и В
// возыедите А в степень В с помощью рекурсии
//

// Console.Clear();

//Метод ввода 
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

long AxB(int n,int m)
{     

    if (m > 0)
    {   
        return n*AxB(n,m-1);
    }
    else
    {
        return 1;
    }
}

// int n = ReadData("Введите число N: ");
// int m = ReadData("Введите число M: ");
// long sum = AxB(n,m);
// Console.Write(sum);


//Деление

// Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

long AmodB(int n,int m)
{     

    if (m == 2)
    {   
        return 4;
    }
    else
    {
        return AmodB(n,m/2)*AmodB(n,m/2);
    }
}

int n = ReadData("Введите число N: ");
int m = ReadData("Введите число M: ");

DateTime d1 = DateTime.Now;
AxB(n,m);
Console.WriteLine("1" + (DateTime.Now - d1));

// DateTime d2 = DateTime.Now;
// AmodB(n,m);
// Console.WriteLine("2" + (DateTime.Now - d2));

// long sum = AmodB(n,m);
// Console.Write(sum);
