// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// * Сделать вариант для числа длиной до 10 цифр не используя char или string

Console.WriteLine("Введите число");

//Обычный вариант

// string? NumStr = Console.ReadLine();

// if (NumStr != null)
// {
//     char[] dig = NumStr.ToString().ToCharArray();

//     if(dig.Length > 2)
//     {
//     Console.WriteLine((int)(dig[2])-48);
//     }
//     else
//     {
//     Console.WriteLine("Третьей цифры нет");
//     }
// }


// Вариант со *
int? NumStr = Convert.ToInt32(Console.ReadLine());

//ToInt32 - Преобразует заданное значение в 32-битовое целое число (не в 16 битовое как short). 

if (NumStr > 0)
{
    if (NumStr > 99)
    {
        while (NumStr > 999)
        {
            NumStr = NumStr / 10;
        }
        Console.WriteLine(NumStr % 10);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}