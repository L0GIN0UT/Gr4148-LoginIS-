// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
// * Отсортируйте массив методом вставки, а затем найдите разницу между первым и последним элементом.

Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод заполнение массива
double[] Gen1DArray(int len, int but, int top)
{
    double[] res = new double[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1) + new Random().NextDouble();
    }
    return res;
}

//Метод печати одномерного массива
void Print1Darray(double[] arr)
{

    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int len = ReadData("Введите длину массива: ");
double[] arr = Gen1DArray(len, 0, 99);
Print1Darray(arr);
double min = arr.Min();
Console.WriteLine("Минимальное значение в Массиве Чисел: " + min);
double max = arr.Max();
Console.WriteLine("Максимальны значение в Массиве Чисел: " + max);
double res = max - min;
Console.WriteLine("Разница: " + res);

//Не успел сделать задание со * к занятию
// К следующему прикреплю

// Console.Clear();

// //Метод ввода 
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// //Метод заполнение массива
// double[] Gen1DArray(int len, int but, int top)
// {
//     double[] res = new double[len];
//     for (int i = 0; i < len; i++)
//     {
//         res[i] = new Random().Next(but, top + 1) + new Random().NextDouble();
//     }
//     return res;
// }

// //Метод печати одномерного массива
// void Print1Darray(double[] arr)
// {

//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ",");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }
// // Сортировка вставками
// static void Swap(int[] array, int i, int j)
// {
//     int temp = array[i];
//     array[i] = array[j];
//     array[j] = temp;
// }
// static void InsertionSort(int[] inArray)
// {
//     int x;
//     int j;
//     for (int i = 1; i < inArray.Length; i++)
//     {
//         x = inArray[i];
//         j = i;
//         while (j > 0 && inArray[j - 1] > x)
//         {
//             Swap(inArray, j, j - 1);
//             j -= 1;
//         }
//         inArray[j] = x;
//     }
// }

// int len = ReadData("Введите длину массива: ");
// double[] arr = Gen1DArray(len, 0, 99);
// Print1Darray(arr);
// int[] newArray = InsertionSort(arr);
// Print1Darray(arr);
// double min = arr.Min(arr[i]);
// Console.WriteLine("Первое значение в Массиве Чисел: " + min);
// double max = arr.Max(arr[i]);
// Console.WriteLine("Последнее значение в Массиве Чисел: " + max);
// double res = max - min;
// Console.WriteLine("Разница: " + res);
