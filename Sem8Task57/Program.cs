// Задача №57
// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается
// элемент входных данных.


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

int[] Dictionary2D(int [,] arr,int count)
{
    int[] outArray = new int[count];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            outArray[arr[i,j]]++;
        }
    } 
    return outArray;   
}
void Print1DArray(int[] arr)

{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int m = ReadData("Введите Колличество строк: ");
int n = ReadData("Введите Колличество столбцов: "); 
int[,] arr = Gen2DArray(m,n,0,9);
Print2Darray(arr);
Console.WriteLine();
Console.WriteLine("[1 2 3 4 5 6 7 8 9 0]");
int [] arrFreq = Dictionary2D(arr,10);
Print1DArray(arrFreq);

