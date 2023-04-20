// Задача №37
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// //Метод печати одномерного массива
// void Print1Darray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ",");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// //Заполнение массива
// int[] Gen1DArray(int len, int top, int but)
// {
//     int[] res = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         res[i] = new Random().Next(but, top + 1);
//     }
//     return res;
// }

// //Подсчёт кол-ва в массиве
// int[] ConvertArr(int[] arr)
// {

//     int len = (arr.Length % 2 == 0) ? arr.Length / 2 : arr.Length / 2 + 1;
//     int[] OutArr = new int[len];

//     for (int i = 0; i < len; i++)
//     {
//         OutArr[i] = arr[i] * arr[arr.Length - 1 - i];
//     }

//     return OutArr;
//     // if(arr.Length%2 = 0)
//     // {
//     //     int OutArray = new int[arr.Length/2];
//     // }
//     // else
//     // {
//     //     int OutArray = new int[arr.Length/2 + 1];
//     // }

//     // for(int i=0; i<arr.Length; i++)
//     // {   
//     //    OutArray[i] = arr[i] +arr[arr.Length -1 -i];

//     // }
// }

// int[] arr = Gen1DArray(10, 50, -50);
// Print1Darray(arr);
// Console.WriteLine(OutArr);

   int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res =  int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

int[] Gen1Darray(int len, int minValue, int maxValue)

{

    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
    }
    return arr;
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

int[] ConverArr (int[] arr)
{
int len =(arr.Length%2==0)? arr.Length/2:arr.Length/2+1;    
int[] outArr = new int [len];

for(int i=0;i <len; i++)
{
outArr [i] = arr[i] * arr[arr.Length-1-i];
}

return outArr;
 }

 int Length = ReadData("Введите длину массива: ");
int[] arr = Gen1Darray(Length,100,0);
Print1DArray (arr);
ConverArr(arr);
Print1DArray(arr);
