// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Clear();

// //Метод ввода 
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// //Метод генерации массива
// int[,] Gen2DArray(int countRow, int countColumn, int but, int top)
// {
//     if (but > top)
//     {
//         int buf = top;
//         top = but;
//         but = buf;
//     }
//     int[,] res = new int[countRow, countColumn];

//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             res[i, j] = new Random().Next(but, top + 1);
//         }
//     }
//     return res;
// }

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

// //Метод поиска Элемента по координатам
// void SearchElement(int[,] arr, int k, int n)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (i == (k-1) && j == (n-1))
//             {
//                 Console.WriteLine($"Ваш элемент в массиве = {arr[i, j]}");
//             }

//         }
//     } 
// }

// int m = ReadData("Введите колличество строк: ");
// int n = ReadData("Введите колличество столбцов: ");
// int[,] arr = Gen2DArray(m, n, 10, 99);
// Print2Darray(arr);
// int i = ReadData("Введите строку: ");
// int j = ReadData("Введите столбец: ");
// SearchElement(arr, i, j);


// //Числа фиббаначи

Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод генерации массива
long[,] Gen2DArray(int countRow, int countColumn, int but, int top)
{
    long[,] res = new long[countRow, countColumn];
    long fir = 0;
    long las = 1;
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            res[i, j] = res[i,j] + (fir + las);
           (fir , las) = (las,las + fir);
        }
    }
    return res;
}

//Метод печати 2мерного массива 
void PrintElement(long[,] arr, int SearchElement)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {   
            if (arr[i, j] == SearchElement)
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

//Метод печати 2мерного массива 
void Print2Darray(long[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

ConsoleColor ColorChoose(long[,] arr)
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
long[,] arr = Gen2DArray(m, n, 10, 99);
Print2Darray(arr);
int SearchElement = ReadData("Введите искомое число: ");
PrintElement(arr, SearchElement);
