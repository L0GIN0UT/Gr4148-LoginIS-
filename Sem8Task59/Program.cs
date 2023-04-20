// Задача №59
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен
// наименьший элемент массива.

// метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

//метод генерации массива
int[,] Gen2Darray(int countRow, int countColum, int minValue, int maxValue)

{
    int[,] arr = new int[countRow, countColum];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColum; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}


//метод печати двумерного массива
void Print2DArray(int[,] arr)
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
            Console.ForegroundColor = col[new Random().Next(0, 16)];
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}


//Метод замены строк на столбцы
int[] FindMinElm(int[,] matr)
{
    int[] outA = new int[2];
    int minElm = int.MaxValue;
    for (int i = 0; i < matr.GetLength(0); i++) //GetLength - до конца строки(0)/столбца(1)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (minElm > matr[i, j])
            {
                minElm = matr[i, j];
                outA[0] = i;
                outA[1] = j;
            }
        }
    }
    return outA;
}

//Метод замены строк на столбцы
int[,] Regen2DArr(int[,] matr, int[] point)
{
    int[,] outM = new int[matr.GetLength(0)-1, matr.GetLength(1)-1];
    int k = 0;
    int m = 0;
    for (int i = 0; i < matr.GetLength(0); i++) //GetLength - до конца строки(0)/столбца(1)
    {
        m = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i != point[0] && j != point[1])
            {
                outM[k, m] = matr[i, j];
                m++;
            }
        }
        if (i != point[0])
        {           
            k++;
        }
    }
    return outM;
}

int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2Darray(row, col, 10, 99);
Print2DArray(arr2D);
Console.WriteLine();
int[] point = FindMinElm(arr2D);
int[,] outMatr = Regen2DArr(arr2D,point);
Print2DArray(outMatr);
