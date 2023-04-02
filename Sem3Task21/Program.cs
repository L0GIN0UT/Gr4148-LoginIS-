// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//Чистим консоль
Console.Clear();

//Принимает значения из комм строки
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//вычисление длинны
double CalcLengh3D(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    return Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2));
}

int X1 = ReadData("Введите координату X1: ");
int Y1 = ReadData("Введите координату Y1: ");
int Z1 = ReadData("Введите координату Z1: ");
int X2 = ReadData("Введите координату X2: ");
int Y2 = ReadData("Введите координату Y2: ");
int Z2 = ReadData("Введите координату Z2: ");

Console.WriteLine($"Растояние между точками A и B: {CalcLengh3D(X1,Y1,Z1,X2,Y2,Z2)}");

//!!!Когда интуешь переменные важен порядок передачи аргумента в функцию!!!