// Задача №17
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


Console.Clear();
//метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//PrintQuterTest-печатаем тест четверти
void PrintQuterTest(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("1 Четверть");
    if (x > 0 && y < 0) Console.WriteLine("2 Четверть");
    if (x < 0 && y < 0) Console.WriteLine("3 Четверть");
    if (x < 0 && y > 0) Console.WriteLine("4 Четверть");
}

int coordX = ReadData("Введите координату X: ");
int coordY = ReadData("Введите координату Y: ");

PrintQuterTest(coordX, coordY);