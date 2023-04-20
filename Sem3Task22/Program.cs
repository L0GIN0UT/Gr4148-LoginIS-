// Задача №22
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.Clear();

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

string LineGen(int num, int pow)
{
    string res = "";
    for(int i=1;i <= num; i++)
    {
        res += Math.Pow(i, pow) + " ";
    }
    return res;
}

int numN = ReadData("Введите число N: ");
Console.WriteLine(LineGen(numN,1));
Console.WriteLine(LineGen(numN,2));

//   class Program
//     {
//         static void Main(string[] args)
//         {
//             //Информация о задаче 
//             Console.WriteLine("Вывод таблицы умножения");
//             Console.WriteLine("-----------------------");
//             //Основной программный код 
//             for (int i = 1; i <= 9; i++)
//             {
//                 for (int j = 1; j <= 9; j++)
//                     Console.Write(String.Format(" {0:00} |", i*j));
 
//                 Console.WriteLine();
//                 Console.WriteLine("---------------------------------------------");
//             }
//             //Остановка программы 
//             Console.ReadLine();
//         }
//     }