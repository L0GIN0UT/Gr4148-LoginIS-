// Задача №55
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя.

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

//Метод печати одномерного массива 
void Print2Darray(int [,] arr)
{   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {   
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
    
}

//проверка массива на симметричность

//Из строк в столбцы
int[,] FromRowToColumn(int [,] arr)
{
    int[,] InMatrix = new int[arr.GetLength(0),arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0);i++)
    {
        for (int j = 0; j < arr.GetLength(1);j++)
        {
            InMatrix[i,j] = arr[j,i];
        }
    }
    return InMatrix;
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: "); 
int[,] arr = Gen2DArray(m,n,100,0);
Print2Darray(arr);
arr = FromRowToColumn(arr);
Print2Darray(arr);