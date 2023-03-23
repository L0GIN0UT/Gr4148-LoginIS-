//Задача №5
//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число");

string? numNLine = Console.ReadLine();

if (numNLine!= null)
{
    int numN = int.Parse(numNLine);
    
    int startNum = numN*(-1);

    string res = String.Empty;

    while (startNum <= numN)
    {
        res = res + startNum + " ";
        startNum = startNum + 1;
    }
    Console.WriteLine(res);
}