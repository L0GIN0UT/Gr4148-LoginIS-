// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

//Сумма чисел в массиве на нечетных позициях
int SummEl(int []arr)
{
    int res = 0;
    for(int i = 1; i<arr.Length; i++)
    {
        res += arr[i];
        i += 1;
    }
   return res;
}

// Размерность массива и вывод результата
int lenArr = ReadData("Введите длину массива: ");
int[] arr = Gen1DArray(lenArr,99,0);
Print1Darray(arr);
int res = SummEl(arr);
Console.WriteLine($"Сумма чисел стоящих на нечетных местах в массиве: {res}");

// //* Найдите все пары в массиве и выведите пользователю

//Не успел сделать задание со * к занятию
// К следующему прикреплю

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

// //Сумма чисел в массиве на нечетных позициях
// int [] SummEl(int []arr,int max)
// {
//     string res = String.Empty;
//     for(int i = 1; i<arr.Length; i++)
//     {
//         int remain = arr[i];
//         if(remain == arr[i+1])
//         {
//         res =+ remain + arr[i+1];
//         remain += 1;
//         }
//         else
//         {
//             i =+ 1;
//         }
//     }
//    return res;
// }

// // Размерность массива и вывод результата
// string res = "";
// int lenArr = ReadData("Введите длину массива: ");
// int[] arr = Gen1DArray(lenArr,9,0);
// Print1Darray(arr);
// res = SummEl(arr);
// Console.WriteLine(res);