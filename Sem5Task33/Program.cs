// Задача №33
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.


// Console.Clear();
// //Ввод данных
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
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

// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for(int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// int numN = ReadData("Введите число: ");

// void SearchNum(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//       if(numN == arr[i])
//         {
//             Console.WriteLine(numN);
//         }
//         else
//         {
//            Console.WriteLine("Числор не найдено");
//         } 
//     }
// }

// int[] testArr = Gen1DArray(15,-999,999);
// Print1DArr(testArr);
// SearchNum(testArr);


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
void SearchElmArr(int[] arr, int numN)
{
    bool elFind = false;
    for(int i=0; i<arr.Length; i++)
    {   
        
        if(numN == arr[i])
        {
            Console.WriteLine("элемент найден");
            elFind = true;
        }
    }
    if (elFind == false)
    {
        Console.WriteLine("элемент не найден");
    } 
}
int lenArr = ReadData("Введите длину массива: ");
int[] arr = Gen1DArray(lenArr,9,-9);
Print1Darray(arr);
int num = ReadData("Введите искомый элемент: ");
SearchElmArr(arr, num);