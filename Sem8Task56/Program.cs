// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int FindElementLess(int[,] arr)
{   
    int minIndex = 1;
    int min = int.MaxValue;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int res = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            res += arr[i, j];
        }
        if (res < min)
        {
            min = res;
            minIndex = i;
        }
    }
    return minIndex;
}

int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");
int[,] arr = Gen2DArray(m, n, 1, 9);
Print2Darray(arr);
int min = FindElementLess(arr);
Console.WriteLine($"Строка с наименьшей суммой элементов: {min+1} - строка");