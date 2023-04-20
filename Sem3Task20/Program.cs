// Задача №20
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.Clear();

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

double CalcLengh2D(int X1, int Y1, int X2, int Y2)
{
    return Math.Sqrt(Math.Pow((X1-X2),2)+Math.Pow((Y1-Y2),2));
}

int X1 = ReadData("Введите координату X1: ");
int Y1 = ReadData("Введите координату Y1: ");
int X2 = ReadData("Введите координату X2: ");
int Y2 = ReadData("Введите координату Y2: ");

Console.WriteLine($"Растояние между точками A и B: {CalcLengh2D(X1,Y1,X2,Y2)}");