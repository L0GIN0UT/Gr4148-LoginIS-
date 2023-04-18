// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// * Дополнительно диагональ выделить разным цветом.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод генерации массива
int[,] Gen2DArray(int countRow, int countColumn, int but, int top)
{
    if (but > top)
    {
        int buf = top;
        top = but;
        but = buf;
    }
    int[,] res = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            res[i, j] = new Random().Next(but, top + 1);
        }
    }
    return res;
}

//Метод печати 2мерного массива 
void Print2Darray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {   
            if (i == j)
            {
            Console.ForegroundColor = ColorChoose(arr);
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
            }
            else 
            {
                Console.Write(arr[i, j] + " ");
            }
        }
        Console.WriteLine();
    }

}

void AverageSumOfColumnForEver(int[,] arr)
{
    double avSum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            avSum += arr[j, i];
        }
        Console.WriteLine($"Среднее арифметическое {i + 1} столбца = {avSum / 3}");
    }
}

void AverageSumString(int[,] arr)
{
    double avSum = 0;
    string sum = string.Empty;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            avSum += arr[j, i];
        }
        sum += avSum / 3 + " ";
    }
    Console.WriteLine($"Среднее арифметическое столбцов = {sum}");
}

ConsoleColor ColorChoose(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < col.Length; i++)
    {
        for (int j = 0; j < col.Length; j++)
        {
                return col[6];
        }
    }
    return col[14];
}

    int m = ReadData("Введите колличество строк: ");
    int n = ReadData("Введите колличество столбцов: ");
    int[,] arr = Gen2DArray(m, n, 10, 99);
    Print2Darray(arr);
    AverageSumOfColumnForEver(arr);
    AverageSumString(arr);