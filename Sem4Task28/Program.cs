using System.Numerics;

Console.Clear();
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

void PrintResult(string message, BigInteger res)
{
     Console.WriteLine(message+res);
}

BigInteger Factorial (int number)
{
    BigInteger result = 1;               
    for (int i = 1; i<=number; i++)
    {     
         result = result * i;
    }
    return result;                
}

int numberA = ReadData("put number a: ");
BigInteger res1 = Factorial (numberA );
PrintResult ("count:",res1);

