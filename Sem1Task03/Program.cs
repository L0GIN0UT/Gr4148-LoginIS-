//Задача №3
//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("Введите день недели");

string? inLine = Console.ReadLine();

if (inLine != null)
{
    int inNumber = int.Parse(inLine);

    if (inNumber == 1)
    {
        Console.WriteLine("Понедельник");
    }

    if (inNumber == 2)
    {
        Console.WriteLine("Вторник");
    }

    if (inNumber == 3)
    {
        Console.WriteLine("Среда");
    }

    if (inNumber == 4)
    {
        Console.WriteLine("Четверг");
    }

    if (inNumber == 5)
    {
        Console.WriteLine("Пятница");
    }

    if (inNumber == 6)
    {
        Console.WriteLine("Суббота");
    }

    if (inNumber == 7)
    {
        Console.WriteLine("Воскресенье");
    }
}

//2 вариант решения задачи
//Console.WriteLine("Введите день недели");
//string? dayLine = Console.ReadLine();

//if (dayLine != null) 
//{
   // string[] dayWeek = new string[7];
    //dayWeek[0] = "Понедельник";
    //dayWeek[1] = "Вторник";
    //dayWeek[2] = "Среда";
    //dayWeek[3] = "Четверг";
    //dayWeek[4] = "Пятница";
    //dayWeek[5] = "Суббота";
    //dayWeek[6] = "Воскресенье";

    //int day = int.Parse(dayLine);

    //if ((0 < day) && (day < 8)) {
        //Console.WriteLine(dayWeek[day-1]);
   // }
   // else Console.WriteLine("Неправильный день недели");

//}



//Переписать 3 вариант решения со скриншота
//Сделать 4 способом (с использованием знания компа о дне недели)