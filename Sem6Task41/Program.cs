// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    string line = Console.ReadLine();
    int res = Convert.ToInt32(line);
    return res;
}

int[] ArrayIn(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
        {
            arr[i] = ReadData($"Ввендите {i+1}-ое число: ");
        }
        return arr;
}


int  CountNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count; 
}

int len = ReadData("Введите колличество элементов: ");
int[] arr = ArrayIn(len);
Console.WriteLine($"Программа нашла '{CountNum(arr)}' чисел больше 0");
 
//Задание со *
//Задание разобраное на 7 сеитнаре

// using System.Text.RegularExpressions; //без явного указания сборки не работают регулярные выражения.

// int taps = ReadData("Введите количество нажатий");
// string inputLine = ReadLineData("Введите любые символы с клавиатуры.");
// Console.WriteLine(inputLine);
// FindNumbersInString(inputLine,taps);
// //Ввод числа
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// //метод считывает нажатие клавиш на клавиатуре заданное количество раз 
// // и собирает данные в строку через запятую
// string ReadLineData(string msg) 
// {
//     Console.WriteLine(msg);
//     string line = "";
//     for (int i = 0; i < taps; i++)
//     {
//         var key = Console.ReadKey(true); //параметр true указан для того, чтобы после нажатия клавиш ничего не появлялось в консоли
//         line = line + String.Format(key.KeyChar.ToString()) + ",";
//     }
//     line = line.TrimEnd(','); //кусь последнюю запятую
//     return line;
// }

// void FindNumbersInString(string str, int count)//метод для поиска десятичных цифр в строке с помощью регулярных выражений
// {
// Regex regex = new Regex(@"\d");//задаем для поиска параметр "любая десятичная цифра"
// MatchCollection matches = regex.Matches(str); //задаем коллекциюЮ состоящую из найденных по условию выражений 
// int posNums = 0;
// if (matches.Count > 0) //если цифры найдены, то накапливаем результат. Каждая найденная цифра +1 к итогу.
// {
//     foreach (Match match in matches)
//     {
//         posNums = posNums + 1;
//     }
//     Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов найдено чисел: {posNums}");
// }
// else
// {
//     Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов чисел не найдено");
// }
// }

