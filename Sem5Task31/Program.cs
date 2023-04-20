// Задача №31
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

Console.Clear();

int globPosSum = 0;
int globNegSum = 0;

int[] Gen1DArray(int len, int minValue, int maxValue)
{
    //защита от дурака
    if(minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;

    }
    
    Random rnd = new Random();
    int[] arr = new int[len];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue +1);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void NegPosSumV1(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            globPosSum += arr[i];
        }
        else
        {
            globNegSum = globNegSum + arr[i];
        }
    }
}

int[] testArr = Gen1DArray(12,-9,9);
Print1DArr(testArr);
NegPosSumV1(testArr);
Console.WriteLine("Сумма положительных чисел в массиве: " + globPosSum);
Console.WriteLine("Сумма отрицательных чисел в массиве: " + globNegSum);