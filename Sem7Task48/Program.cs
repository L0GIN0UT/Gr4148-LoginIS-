﻿// Задача №48
// Цветной массив на ваш вкус

Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод заполнение массива
int[,] Gen2DArray(int countRow, int countColumn, int but, int top)
{

    //Защита от дурака
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(but, top + 1);
        }

    }
    return arr;
}

//метод покраски массива
int[,] ColorArray(int[,] arr, int arrTask)
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
            if (arrTask == 16)
            {
                Console.ForegroundColor = col[new Random().Next(0, 16)];
                Console.Write(arr[i, j] + " ");
                Console.ResetColor();
            }
            if (arrTask == 17)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.ForegroundColor = col[0];
                    Console.Write(arr[i, j] + " ");
                }
                else
                {
                    Console.ForegroundColor = col[15];
                    Console.Write(arr[i, j] + " ");
                }
                Console.ResetColor();
            }
            if (arrTask < 16)
            {
                Console.ForegroundColor = col[arrTask];
                Console.Write(arr[i, j] + " ");
                Console.ResetColor();
            }
        }
        Console.WriteLine();
    }
    return arr;
}



// //Метод печати 2мерного массива 
// void Print2Darray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

// }


int row = ReadData("Введите колличество строк: ");
int col = ReadData("Введите колличество столбцов: ");
int Task = ReadData("В какой цвет вы хотите раскрасить массив \n Черный(0) \n Синий(1) \n Циан(2) \n Темно-Синий(3) \n Темный-Циан(4) \n Темно-Серый(5) \n Темно-Зеленый(6) \n Темный-Маджента(7) \n Темно-красный(8) \n Темно-Желтый(9) \n Серый(10) \n Зеденый(11) \n Маджента(12) \n Красный(13) \n Белый(14) \n Желтый(15) \n Разоцветный(16) \n Шахматы(17) \n Обычный(18 и больше) \n Введите число: ");
int[,] arr2D = Gen2DArray(row, col, 10, 99);
arr2D = ColorArray(arr2D,Task);
