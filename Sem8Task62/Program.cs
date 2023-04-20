// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод генерации массива
int[,] Gen2DSpiralArray(int countRow, int countColumn, int but, int top)
{
    {
        
        int res = 1;
        int[,] arr = new int[but, top];
        //Заполняем периметр массива по часовой стрелке.
        for (int j = 0; j < top; j++)
        {
            arr[0, j] = res;
            res++;
        }
        for (int i = 1; i < but; i++)
        {
            arr[i, top - 1] = res;
            res++;
        }
        for (int j = top - 2; j >= 0; j--)
        {
            arr[but - 1, j] = res;
            res++;
        }
        for (int i = but - 2; i > 0; i--)
        {
            arr[i, 0] = res;
            res++;
        }
        //продолжение заполнения массива
        //тк выше мы заполнели его только по 1
        //во всех направлениях
        int m = 1;
        int n = 1;

        while (res < but * top)
        {
            //Движемся вправо.
            while (arr[m, n + 1] == 0)
            {
                arr[m, n] = res;
                res++;
                n++;
            }

            //Движемся вниз.
            while (arr[m + 1, n] == 0)
            {
                arr[m, n] = res;
                res++;
                m++;
            }

            //Движемся влево.
            while (arr[m, n - 1] == 0)
            {
                arr[m, n] = res;
                res++;
                n--;
            }

            //Движемся вверх.
            while (arr[m - 1, n] == 0)
            {
                arr[m, n] = res;
                res++;
                m--;
            }
        }

        // Убираем незаполненную ячейку в центре при помощи следующего цикла.
        for (int i = 0; i < but; i++)
        {
            for (int j = 0; j < top; j++)
            {
                if (arr[i, j] == 0)
                {
                    arr[i, j] = res;
                }
            }
        }

        return arr;
    }
}

//Метод печати 2мерного массива 
void Print2DSpiralarray(int[,] arr)
{
    //Выводим массив в консоль.
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //Сравнение для более красивого вывода в консоль
            //крассиво только для 10            
            if (arr[i, j] < 10)
            {   
                Console.Write(arr[i, j] + "  ");
            }
            else
            {
                Console.Write(arr[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}

int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");
int[,] arr = Gen2DSpiralArray(m, n, m, n);
Print2DSpiralarray(arr);