// Задача №49
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
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
        for (int j = 0; j < countRow; j++)
    {
        arr[i,j] = new Random().Next(but, top + 1); 
    }
    
    }
    return arr;
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
int[,] FillArrayMod2Square(int [,] arr)
{   

    for (int i = 0; i < arr.GetLength(0); i=i+2)
    {
        for (int j = 0; j < arr.GetLength(1); j=j+2)
        {
            arr[i,j] = arr[i,j] * arr[i,j];
        }
        
    }
    return arr;
}

int row = ReadData ("Введите колличество строк: ");
int col = ReadData ("Введите колличество столбцов: ");
int [,] arr2D = Gen2DArray (row,col,10,99);
int [,] arr = FillArrayMod2Square(arr2D);
Print2Darray(arr);