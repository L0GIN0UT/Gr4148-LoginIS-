// Задача №39
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

//Ввод числа
int[] Gen1DArr(int len, int top, int but)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1);
    }
    return res;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void SwapArray(int[] arr)
{
    int buf = 0;
    for(int i=0; i<arr.Length/2;i++)
    {
        //(arr[i], arr[arr.Length-1-i]) = (arr[arr.Length-1-i], arr[i]);
        buf = arr[i];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = buf;
    }
}

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for(int i=0; i<arr.Length;i++)
    {
        outArr[outArr.Length-1-i]=arr[i];
    }
    return outArr;
}

int[] testArray = Gen1DArr(1000000,100,10);
//Print1DArr(testArray);

DateTime d1 = DateTime.Now;
//int[] newArray = SwapNewArray(testArray);

SwapArray(testArray);
Console.WriteLine(DateTime.Now - d1);
//Print1DArr(newArray);
//Print1DArr(testArray);