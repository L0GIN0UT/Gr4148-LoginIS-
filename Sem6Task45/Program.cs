// Задача №45
// Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.


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
// void CopyArray(int []arr)
// {
//     while(CopyArray.Length < Gen1DArray.Length)
//     {
//         Gen1DArray[i] == CopyArray[i];
//         i++;
//     }
// }
// метод копирования массива
int [] CopyArr(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
       outArr[i]=arr[i];
    }
    return outArr;
}

int[] arr = Gen1DArray(15,999,0);
Print1Darray(arr);
int [] newArray = CopyArr(arr);
Print1Darray(arr);
