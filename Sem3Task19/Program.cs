// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Clear();

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// //Проверка на полиндром
// void PalindromTest(int num)
// {
//     int Check1 = num/10000;
//     int Check5 = num%10;
//     int Check2 = (num/1000)%10;
//     int Check4 = (num/10)%10;

// if ((Check1 == Check5) && (Check2 == Check4)) Console.WriteLine("Да это число полиндром");
// else
// {
//    Console.WriteLine("Нет это число неполиндром"); 
// }
    
// }
// int num = ReadData("Введите пятизначное число: ");

// PalindromTest(num);

//* Сделать вариант через СЛОВАРЬ четырехзначных палиндромов



Console.Clear();
//Ввод данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//Создание словаря
var palindroms = new Dictionary<int, int>();
//Ключи к словарю
int k = 0;

//Заполнение словаря
for(int i = 1; i < 10 ; i++)
{
    for(int j = 0 ; j < 10 ; j++)
    {
        palindroms.Add(k, 1000*i + 100*j + 10*j + i);
        k++;
    }
}

int numN = ReadData("Введите 4 значное число: ");

//Проверка на палиндромность
bool isPalindrom = false;
for(int i = 0 ; i < palindroms.Count ; i++)
{
    if(numN == palindroms[i])
    {
        Console.WriteLine("Число является Палиндромом");
        isPalindrom = true;
    }
}
if (isPalindrom == false)
{
     Console.WriteLine("Число Не является Палиндромом");
}

//Вывод словаря
// for(int i = 0; i < palindroms.Count ; i++)
// {
//     Console.WriteLine(palindroms[i]);
// }