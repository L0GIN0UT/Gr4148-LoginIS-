// Задача №18
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();
//чтение данных консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//печатаем тест координат
//метод ответа
void PrintCoordTest(int quater)
{
    if (quater == 1) Console.WriteLine("x > 0 , y > 0");
    if (quater == 2) Console.WriteLine("x > 0 , y < 0");
    if (quater == 3) Console.WriteLine("x < 0 , y < 0");
    if (quater == 4) Console.WriteLine("x < 0 , y > 0");
}

//Вызов метода
int quaterINT = ReadData("Введите Номер Четверти: ");

PrintCoordTest(quaterINT);


//try catch для рассматривания ошибок
// может перехватывать как все типы так и какой то конкретный



// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите номер четверти (от 1 до 4): ");
//         int quarter = int.Parse(Console.ReadLine());

//         // Объявляем переменные для хранения диапазона координат
//         double xMin, xMax, yMin, yMax;

//         // Вычисляем диапазон координат для каждой четверти
//         if (quarter == 1)
//         {
//             xMin = 0;
//             xMax = double.PositiveInfinity; // положительная бесконечность
//             yMin = 0;
//             yMax = double.PositiveInfinity;
//         }
//         else if (quarter == 2)
//         {
//             xMin = double.NegativeInfinity; // отрицательная бесконечность
//             xMax = 0;
//             yMin = 0;
//             yMax = double.PositiveInfinity;
//         }
//         else if (quarter == 3)
//         {
//             xMin = double.NegativeInfinity;
//             xMax = 0;
//             yMin = double.NegativeInfinity;
//             yMax = 0;
//         }
//         else if (quarter == 4)
//         {
//             xMin = 0;
//             xMax = double.PositiveInfinity;
//             yMin = double.NegativeInfinity;
//             yMax = 0;
//         }
//         else
//         {
//             Console.WriteLine("Ошибка: номер четверти должен быть от 1 до 4");
//             return; // завершаем программу, если номер четверти не корректен
//         }

//         // Выводим результат
//         Console.WriteLine("Диапазон координат в четверти {0}:\n x ∈ [{1}, {2}], y ∈ [{3}, {4}]", 
//             quarter, xMin, xMax, yMin, yMax);
//     }
// }