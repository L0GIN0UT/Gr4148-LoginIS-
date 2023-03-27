// Задача №11
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

System.Random numSintezator = new System.Random();
int rndmNum = numSintezator.Next(100 , 1000);
Console.WriteLine(rndmNum);

int poz1 = (rndmNum/100);
int poz2 = (rndmNum%10);

int newpoz = poz1 * 10 + poz2;

Console.WriteLine(newpoz);

//int res = rndNum/100*10+rndNum%10

//int rndmNum = numSintezator.Next(100 , 1000);
//Console.WriteLine(rndNum/100*10+rndNum%10);

//Через Массив
// System.Random numSintezator = new System.Random();

// char[] digits = numSintezator.Next(100, 1000).ToString().ToCharArray();
// Console.WriteLine(digits);
// char[] res = {digits[0], digits[2]};
// Console.WriteLine(res);