// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] CompositionOfArrays(int[,] first, int[,] second)
{
    
    if (first.GetLength(1) != second.GetLength(0)) throw new Exception("Матрицы должны быть одного размера");
    int[,] res = new int[first.GetLength(0), second.GetLength(1)];
    {
        for (int i = 0; i < first.GetLength(0); i++)
        {
            for (int j = 0; j < second.GetLength(1); j++)
            {
                for (int k = 0; k < second.GetLength(0); k++)
                {
                    res[i, j] += first[i, k] * second[k, j];
                }
            }
        }
    }
    return res;
}

int m = ReadData("Введите количество строк 1 матрицы: ");
int n = ReadData("Введите количество столбцов 1 матрицы: ");
int[,] firstArr = Gen2DArray(m, n, 1, 9);
int x = ReadData("Введите количество строк 2 матрицы: ");
int y = ReadData("Введите количество столбцов 2 матрицы: ");
int[,] secondArr = Gen2DArray(x, y, 1, 9);
Print2Darray(firstArr);
Console.WriteLine();
Print2Darray(secondArr);
Console.WriteLine();
try{
int [,] compArr = CompositionOfArrays(firstArr, secondArr);
Print2Darray(compArr);
}
catch(Exception e){Console.WriteLine(e.Message);}





