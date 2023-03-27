// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary

// Обычный вариант
// Console.WriteLine("Введите число");

// int? NumInt = Convert.ToInt32(Console.ReadLine());

// if ((NumInt <= 7) && (NumInt >= 1))
// {
//     if (NumInt == 6 || NumInt == 7)
//     {
//         Console.WriteLine("Да, Выходной");
//     }
//     else
//     {
//         Console.WriteLine("Нет, надо идти на работу");
//     }
// }

//Вариант с использованием Dictionary
Console.WriteLine("Введите число");

string? NumStr = Console.ReadLine();
if (NumStr != null)
{
int NumInt = int.Parse(NumStr);
var week = new Dictionary<int , string>()
{
    { 1, "Понедельник, будний день!"},
    { 2, "Вторник, будний день!"},
    { 3, "Среда, будний день!"},
    { 4, "Четверг, будний день!"},
    { 5, "Пятница, будний день!"},
    { 6, "Суббота, выходной!"},
    { 7, "Воскресенье, выходной!"},

};
Console.WriteLine(week[NumInt]);
}
