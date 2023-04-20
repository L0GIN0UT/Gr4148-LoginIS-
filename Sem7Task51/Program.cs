// Задача №51
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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

    //Защита от дурака
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


//Метод печати 2мерного массива 
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

void SummIndexDiagonal2Darray(int[,] arr)
{   int sum = 0;
    int len = (arr.GetLength(0) > arr.GetLength(1))?arr.GetLength(1):arr.GetLength(0);
    for (int i = 0; i < len; i++)
    {
        sum += arr[i,i];
    }
    Console.WriteLine(sum);
}

int row = ReadData ("Введите колличество строк: ");
int col = ReadData ("Введите колличество столбцов: ");
int [,] arr2D = Gen2DArray (row,col,10,99);
Print2Darray(arr2D);
SummIndexDiagonal2Darray(arr2D);