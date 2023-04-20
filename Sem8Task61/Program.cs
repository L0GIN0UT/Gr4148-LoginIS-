// Задача №61
// Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного
// треугольника
Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Факториал числа
long Factor(int n)
{
    long res = 1;
    for (int i = 1; i <= n; i++)
    {
        res *= i;
    }
    return res;
}

void PrintPascalTriangle(int nRaw)
{
    for (int i = 0; i < nRaw; i++)
    {
        for(int k =0; k<nRaw-i;k++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(Factor(i) / (Factor(j) * Factor(i - j)));
        }
        Console.WriteLine();
    }
}

int countRaw = ReadData("Введите колличество строк треугольника Паскаля: ");
PrintPascalTriangle(countRaw);


