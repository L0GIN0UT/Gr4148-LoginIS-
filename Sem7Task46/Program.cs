// Задача №46
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод заполнение массива
int[,] Gen2DArray(int countRow,int countColumn, int but, int top)
{
    int[,] arr = new int[countRow,countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
    {
        arr[i,j] = new Random().Next(but, top + 1); 
    }
    
    }
    return arr;
}

//Метод печати одномерного массива 
void Print2Darray(int [,] arr)
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
            Console.ForegroundColor = col[new Random().Next(11)];
            Console.Write(arr[i,j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    
}

int row = ReadData ("Введите колличество строк: ");
int col = ReadData ("Введите колличество столбцов: ");
int [,] arr2D = Gen2DArray (row,col,10,99);
Print2Darray(arr2D);