// Задача №40
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}


void CompSide(int FirstSide,int SecondSide, int ThirdSide)
{
    if((FirstSide + SecondSide) < ThirdSide || (SecondSide + ThirdSide) < FirstSide || (FirstSide + ThirdSide) < SecondSide)
    {
            Console.WriteLine("Треугольник с такими сторонами существует");
    }
    else
    {
        Console.WriteLine("Треугольник с такими сторонами Не существует");
    }
}

int FirstSide = ReadData("Введите Размер 1 стороны: ");
int SecondSide = ReadData("Введите Размер 2 стороны: ");
int ThirdSide = ReadData("Введите Размер 3 стороны: ");

CompSide(FirstSide,SecondSide,ThirdSide);