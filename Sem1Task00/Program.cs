//Задача №0
//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

//Считываем данные с консоли
string? inLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inLine!=null)
{
    //Парсим введеное число
    int inNumber = int.Parse(inLine);
    
    //2 способ решения задачи (Использование внутренних программ)
    //int outStrtPow = (int)Math.Pow(inNumber,2)
    //Console.WriteLine(outStrtPow);
    
    //Находим квадрат числа
    int outNumber = inNumber*inNumber;

    //Выводим данные в консоль
    Console.WriteLine(outNumber);

}
