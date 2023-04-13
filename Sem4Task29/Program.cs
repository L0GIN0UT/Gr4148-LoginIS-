// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// *Дополнительно: Написать программу которая из имен через запятую выберет случайное
// имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора
// случайного имени метод Random.Next(1,<длина массива имен>+1).


// // Массив из N Элементов
// // Ввод числа
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
// int[] Gen1DArray(int len)
// {
//     int[] res=new int[len];
//     for(int i=0; i<len; i++)
//     {
//         res[i]= new Random().Next(-999, 1000);
//     }
//     return res;
// }

// int lenArr = ReadData("Введите длину массива: ");
// int[] arr = Gen1DArray(lenArr);
// Print1Darray(arr);


//Задание со звездочкой

// Ввод списка имен и его разделение
string[] ReadData(string msg)
{
    Console.Write(msg);
    string? names = Console.ReadLine();
    string[] res = names.Split(' ');
    return res;
}

//Метод печати одномерного массива
void Print1Darray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Метод выбора случайного имени
string PersonChoose(string[] arr)
{
    int i = new Random().Next(0, arr.Length);
    return arr[i];
}

string[] arrayNames = ReadData("Введите имена через пробел !!!Используя Транслитерат!!!: ");
Print1Darray(arrayNames);
string res = PersonChoose(arrayNames);
Console.WriteLine(res);


