//Задача №9
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

//Вариант 1
System.Random numSintezator = new System.Random();
int rndmNum = numSintezator.Next(10 , 100);
Console.WriteLine(rndmNum);

//short тип данных короткий 
//short poz1 = (short)(rndmNum/10); short остается short а не переходит в int и выдает ошибку

short poz1 = (short)(rndmNum/10);
short poz2 = (short)(rndmNum%10);

 if (poz1 < poz2)
{
    Console.WriteLine(poz2);
}
else
{
   Console.WriteLine(poz1);
}


//Вариант 2

//ToString() - 
//ToCharArray() - 

//char [] digist = numSintezator.Next(10,100).ToString().ToCharArray();
// 23 -> "23" -> ['2','3']
//Console.WriteLine(digist);

//firstNum = (int)(digist[0])-48;
//secondNum = (int)(digist[1])-48;
//<переменная> = (условие)?<значение1>:<значение2>;
//if (poz1 < poz2)
//{
//   Console.WriteLine(poz2);
//}
//else
//{
//    Console.WriteLine(poz1);
//}
//int res = (firstNum > secondNum)?firstNum:secondNum;
//console.WriteLine(res);

//Вариант 3
//int rndmNumArr = numSintezator.Next(10,100);
//Console.WriteLine(rndmNumArr);
//int [] indxAnsw = new int [90];

//console.WriteLine 

// если из инт в чар то 0 становится не 0 а 0+48 
// по этому надо в конце вычесть 48