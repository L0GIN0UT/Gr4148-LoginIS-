//Задача №7
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите число");

string? num = Console.ReadLine();

if (num!= null)
{
int number = int.Parse(num);

int res = number%10;

Console.WriteLine(res);
}

//char[] charArr=number.ToCharArray

//" " - [" "]
