// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых

// 1 Версия не рабочая
// const int X = 0;
// const int Y = 1;

// int ReadData(string msg)
// {
//     Console.Write(msg);
//     string row = Console.ReadLine();
//     int res = Convert.ToInt32(row);
//     return res;
// }

// int[] FromIntToArr(int len = 4)
// {
//     int[] arr = new int[len];
//     for(int i = 0; i < len; i++)
//     {
//        arr[0] = ReadData($"Ввендите b1: ");
//        arr[1] = ReadData($"Ввендите k1: ");
//        arr[2] = ReadData($"Ввендите b2: ");
//        arr[3] = ReadData($"Ввендите k2: "); 
//     }
//     return arr;
// }

// int[] FindCoords (int []arr)
// {
//   int[] coord = new int[2];
//   coord[X] = (arr[2] - arr[0]) / (arr[1] - arr[3]);
//   coord[Y] = arr[1] * coord[X] + arr[0];
//   return coord;
// }

// int len = ReadData("Введите колличество элементов (4): ");
// int[] arr = FromIntToArr(len);
// arr = FindCoords(arr);

// //Версия 2 Рабочая
// const int X = 0;
// const int Y = 1;
// const int coef = 0;
// const int con = 1;
// const int Line1 = 1;
// const int Line2 = 2;

// //Вызов метода для записи чисел
// double[] LineData1 = LineData(Line1);
// double[] LineData2 = LineData(Line2);

// if (IntersectLines(LineData1, LineData2))
// {
//     double[] coord = FindCoords(LineData1, LineData2);
//     Console.WriteLine($"Точка пересечений уравнений Y = {LineData1[coef]}*X+{LineData1[con]} /n Y= {LineData2[coef]}*X+{LineData2[con]}");
//     Console.WriteLine($"Имеет координаты ({coord[X]}, {coord[Y]})");
// }

// //Ввод числа
// double ReadMSG(string msg)
// {
//     Console.Write(msg);
//     string row = Console.ReadLine();
//     double res = Convert.ToDouble(row);
//     return res;
// }

// //Данные в пямую
// double[] LineData(int NumOfLines)
// {
//     double[] LineData = new double[2];
//     LineData[coef] = ReadMSG($"Введите k для {NumOfLines} прямой: ");
//     LineData[con] = ReadMSG($"Введите b для {NumOfLines} прямой: ");
//     return LineData;
// }

// //Поиск координат
// double[] FindCoords(double[] LineData1, double[] LineData2)
// {
//     double[] coord = new double[2];
//     coord[X] = (LineData1[con] - LineData2[con]) / (LineData2[coef] - LineData1[coef]);
//     coord[Y] = LineData1[coef] * coord[X] + LineData1[con];
//     return coord;
// }

// //Проверка неа пересечение прямых
// bool IntersectLines(double[] LineData1, double[] LineData2)
// {
//     if (LineData1[coef] == LineData2[coef])
//     {
//         if (LineData1[con] == LineData2[con])
//         {
//             Console.WriteLine("Прямые пересекаются");
//             return false;
//         }
//         else
//         {
//             Console.WriteLine("Прямые не пересекаются");
//             return false;
//         }
//     }
//     return true;
// }

//Версия Задание со * 
const int X1 = 0;
const int Y1 = 1;
const int X2 = 0;
const int Y2 = 1;
const int X3 = 0;
const int Y3 = 1;
const int coef = 0;
const int con = 1;
const int Line1 = 1;
const int Line2 = 2;
const int Line3 = 3;

//Вызов метода для записи чисел
double[] LineData1 = LineData(Line1);
double[] LineData2 = LineData(Line2);
double[] LineData3 = LineData(Line3);

if (IntersectLines(LineData1, LineData2,LineData3))
{
    double[] coord = FindCoords(LineData1, LineData2,LineData3);
    Console.WriteLine($"Точка пересечений уравнений Y = {LineData1[coef]}*X+{LineData1[con]} /n Y= {LineData2[coef]}*X+{LineData2[con]}");
    Console.WriteLine($"Имеет координаты ({coord[X1]}, {coord[Y1]})");
    Console.WriteLine($"Точка пересечений уравнений Y = {LineData2[coef]}*X+{LineData2[con]} /n Y= {LineData3[coef]}*X+{LineData3[con]}");
    Console.WriteLine($"Имеет координаты ({coord[X2]}, {coord[Y2]})");
    Console.WriteLine($"Точка пересечений уравнений Y = {LineData1[coef]}*X+{LineData1[con]} /n Y= {LineData3[coef]}*X+{LineData3[con]}");
    Console.WriteLine($"Имеет координаты ({coord[X3]}, {coord[Y3]})");

}

//Ввод числа
double ReadMSG(string msg)
{
    Console.Write(msg);
    string row = Console.ReadLine();
    double res = Convert.ToDouble(row);
    return res;
}

//Данные в пямую
double[] LineData(int NumOfLines)
{
    double[] LineData = new double[3];
    LineData[coef] = ReadMSG($"Введите k для {NumOfLines} прямой: ");
    LineData[con] = ReadMSG($"Введите b для {NumOfLines} прямой: ");
    return LineData;
}

//Поиск координат
double[] FindCoords(double[] LineData1, double[] LineData2, double[] LineData3)
{
    double[] coord = new double[6];
    coord[X1] = (LineData1[con] - LineData2[con]) / (LineData2[coef] - LineData1[coef]);
    coord[Y1] = LineData1[coef] * coord[X1] + LineData1[con];
    coord[X2] = (LineData2[con] - LineData3[con]) / (LineData3[coef] - LineData2[coef]);
    coord[Y2] = LineData1[coef] * coord[X2] + LineData1[con];
    coord[X3] = (LineData3[con] - LineData1[con]) / (LineData1[coef] - LineData3[coef]);
    coord[Y3] = LineData1[coef] * coord[X3] + LineData1[con];
    return coord;
}

//Проверка на пересечение прямых
bool IntersectLines(double[] LineData1, double[] LineData2, double[] LineData3)
{
    if (LineData1[coef] == LineData2[coef] && LineData1[coef] == LineData3[coef])
    {
        if (LineData1[con] == LineData2[con] && LineData1[con] == LineData3[con])
        {
            Console.WriteLine("Прямые пересекаются");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые не пересекаются");
            return false;
        }
    }
    return true;
}



