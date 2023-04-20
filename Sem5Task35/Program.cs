// Задача №35
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


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
// void SearchElmArr(int[] arr, int numN)
// {
//     bool elFind = false;
//     for(int i=0; i<arr.Length; i++)
//     {   
//         int res = 0;
//         if(arr[9] < arr[i] < arr[100])
//         {
//             res = res + arr[i] + ", ";
//             elFind = true;
//         }
//     }
//     if (elFind == false)
//     {
//         Console.WriteLine("элементы не найден");
//     } 
// }
// int[] arr = Gen1DArray(123,999,0);
// Print1Darray(arr);
// SearchElmArr(arr);


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

//Подсчёт кол-ва в массиве
int ElmInRange(int[] arr, int min, int max)
{
    int res = 0;
    for(int i=0; i<arr.Length; i++)
    {   
        if(arr[i]<=max && arr[i]>=min)
        {
            res++;
        }

    }
    return res;
}

int[] arr = Gen1DArray(123,999,0);
Print1Darray(arr);
int res = ElmInRange(arr, 10, 99);
Console.WriteLine("Элементов, лежащих в границах [10;99]: "+ res);