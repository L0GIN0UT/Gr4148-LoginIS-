// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// * Отсортировать массив методом пузырька и подсчета. Сравнить быстродействие методов. Проверку сортировки производить отдельно.
//Сначало запустить программу с одним методом сортировки, а затем с другим. Проверять на длине массива не мение 10000 элементов.

//Заданме без *

// Console.Clear();

// //Ввод числа
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// //Метод печати одномерного массива
// void Print1Darray(int []arr)
// {
//     Console.Write("[");
//     for(int i = 0; i<arr.Length-1; i++)
//     {
//         Console.Write(arr[i]+",");
//     }
//     Console.WriteLine(arr[arr.Length-1] + "]");
// }

// //Заполнение массива
// int[] Gen1DArray(int len, int top, int but)
// {
//     int[] res=new int[len];
//     for(int i=0; i<len; i++)
//     {
//         res[i]= new Random().Next(but, top+1);
//     }
//     return res;
// }

// // Подсчет четных чисел
// int SearchElmArr(int[] arr)
// {
//  int res = 0;
//     for(int i=0; i<arr.Length; i++)
//     {   
//         if(arr[i] % 2 == 0)
//         {
//             res += 1;
//         }
//     }
//     return res;
// }

// // Размерность массива и вывод результата
// int lenArr = ReadData("Введите длину массива: ");
// int[] arr = Gen1DArray(lenArr,999,99);
// Print1Darray(arr);
// int res = SearchElmArr(arr);
// Console.WriteLine($"Четных чисел в массиве: {res}");

// Задание со звездочкой

Console.Clear();

//Ввод числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод печати одномерного массива
void Print1Darray(int []arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i]+",");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}

//Заполнение массива
int[] Gen1DArray(int len, int top, int but)
{
    int[] res=new int[len];
    for(int i=0; i<len; i++)
    {
        res[i]= new Random().Next(but, top+1);
    }
    return res;
}

// Метод Пузырька
static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }                   
                }            
            }
            return mas;
        }

// Метод Подсчета
void BasicCountingSort(int[] arr)
    {
        int max = arr.Max();
        int min = arr.Min();
        int[] count = new int[max - min + 1];
        int z = 0;
        for(int i = 0; i < arr.Length ; i++)
        {
            count[arr[i] - min]++;
        }
        for(int i = min; i <= max ; i++)
        {
            while (count[i - min]-- > 0)
            {
                arr[z] = i;
                z++;
            }
        }
    }

int lenArr = ReadData("Введите длину массива (10000 элементов): ");
int[] arr = Gen1DArray(lenArr,9999,-9999);
Print1Darray(arr);
int [] newArray = BubbleSort(arr);
Print1Darray(arr);
BasicCountingSort(arr);
Print1Darray(arr);

