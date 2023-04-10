// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();
//метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Проверка на знак
double Calculate(double FirstNum, double SecondNum, char Sign )
{
    double res=0;
    switch(Sign)  
    {
        case '+':
        {
            res = FirstNum + SecondNum; 
            break;
        }
        case '*':
        {
            res = FirstNum * SecondNum; 
            break;
        }
        case '/':
        {
            res = FirstNum / SecondNum; 
            break;
        }
        case ':':
        {
            res = FirstNum / SecondNum; 
            break;
        }
        case '^':
        {
            res = Math.Pow(FirstNum,SecondNum); 
            break;
        }
    }

    return res;
}

double FirstNum = ReadData("Введите первое число: ");
Console.Write("Введите операцию: | + | - | / | * | ^ |: ");
char Sign = Convert.ToChar(Console.ReadLine()??"0");
double SecondNum = ReadData("Введите второе число: ");
double Answer = Calculate(FirstNum, SecondNum, Sign);


//Вывод Ответа
Console.Write($"{FirstNum} {Sign} {SecondNum} = {Answer}");
