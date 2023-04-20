// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод заполнение массива
int[,,] Gen3DOrderArray(int countRow, int countColumn, int Pages, int but, int top)
{
    int[,,] res = new int[countRow, countColumn, Pages];
    for (int x = 0; x < countRow; x++)
    {
        for (int y = 0; y < countColumn; y++)
        {
            for (int z = 0; z < Pages; z++)
            {
                res[x, y, z] = new Random().Next(but, top + 1);
            }
        }
    }
    return res;
}

//Метод печати 2мерного массива 
void Print3Darray(int[,,] arr)
{
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                Console.Write(arr[x,y,z] + $"({x}{y}{z})" + " ");
            }
        }
        Console.WriteLine();
    }
}

int x = ReadData("Введите количество строк: ");
int y = ReadData("Введите количество столбцов: ");
int z = ReadData("Введите количество страниц: ");
int[,,] arr = Gen3DOrderArray(x, y, z, 10, 100);
Print3Darray(arr);

