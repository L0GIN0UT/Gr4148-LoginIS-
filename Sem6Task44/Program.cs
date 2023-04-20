// адача №44
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.Clear();

int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод Фибанначи
string Fibbanachi(int NewNum)
{
    string res = "0 1";
    long first = 0;
    long last = 1;
    for(int i =2 ; i < NewNum ; i++)
    {
        res += " "+(first + last);
        (first,last) = (last,first+last);
    }
    return res;
}

string res = " ";
int NewNum = ReadData("Введите число: ");
res=Fibbanachi(NewNum);
Console.WriteLine(res);