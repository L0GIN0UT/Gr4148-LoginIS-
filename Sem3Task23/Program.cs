// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом

Console.Clear();
//ввод данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//возведение числа в куб
string LineGen(int num, int pow)
{
    string res = "";
    for (int i = 1; i <= num; i++)
    {
        res += Math.Pow(i, pow) + "\t| ";
    }
    return res;
}

int numN = ReadData("Введите число N: ");
//цикл для выведения таблицы и значений
for(int i = 0; i  < numN ; i++) Console.Write("|‾‾‾‾‾‾‾");
Console.WriteLine("|");

Console.WriteLine($"|  {LineGen(numN, 1)}");

for(int i = 0; i  < numN ; i++) Console.Write("|‾‾‾‾‾‾‾");
Console.WriteLine("|");

Console.WriteLine($"|  {LineGen(numN, 3)}");

for(int i = 0; i  < numN ; i++) Console.Write("‾‾‾‾‾‾‾‾");