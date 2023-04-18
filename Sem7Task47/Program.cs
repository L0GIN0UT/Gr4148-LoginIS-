// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Clear();

// //Метод ввода 
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// //Метод генерации массива вещественных чисел
// double[,] Gen2DArray(int countRow, int countColumn, int but, int top)
// {
//     double[,] res = new double[countRow, countColumn];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             res[i, j] = new Random().Next(but, top + 1) + new Random().NextDouble();
//         }
//     }
//     return res;
// }

// //Метод печати двумерного массива 
// void Print2Darray(double [,] arr)
// {   
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {   
//             Console.Write(arr[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int row = ReadData("Введите количество строк: ");
// int col = ReadData("Введите количесвто столбцов: ");
// double[,] arr = Gen2DArray(row, col, 0, 100);
// Print2Darray(arr);

//Задание со ****

Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод генерации массива вещественных чисел
double[,] Gen2DArray(int countRow, int countColumn, int but, int top)
{
    double[,] res = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            res[i, j] = new Random().Next(but, top + 1) + new Random().NextDouble();
        }
    }
    return res;
}

//Метод печати двумерного массива 
void Print2Darray(double[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            char[] numbers = arr[i, j].ToString().ToCharArray();
            for (int k = 0; k < numbers.Length; k++)
            {
                Console.ForegroundColor = col[new Random().Next(0, 16)];
                Console.Write(numbers[k]);
                Console.ResetColor();
            }
            Console.Write("   ");
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количесвто столбцов: ");
double[,] arr = Gen2DArray(row, col, 0, 100);
Print2Darray(arr);

