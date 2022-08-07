int[] CreatArray(int size, int minValue, int MaxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, MaxValue + 1);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2


int PositiveOfnumber(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter += 1;
        }
    }
    return counter;
}


Console.Write("Введите размер желаемого массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int minValue = 100;
int maxValue = 999;

int[] array = CreatArray(size, minValue, maxValue);
int result = PositiveOfnumber(array);
ShowArray(array);
Console.Write($"Колличество четных элементов в масииве {result}");

*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0


int SumPositiveOddPos(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Write("Введите размер желаемого массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите минимальное число диапазона цифр в массиве: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите максимальное число диапазона цифр в массиве: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = CreatArray(size, minValue, maxValue);
int result=SumPositiveOddPos(array);
ShowArray(array);
Console.Write($"Сумма элементов стоящих на нечетных местах в масииве = {result}");


*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76*/

int Max(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}
int Min(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

Console.Write("Введите размер желаемого массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите минимальное число диапазона цифр в массиве: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите максимальное число диапазона цифр в массиве: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = CreatArray(size, minValue, maxValue);
int max=Max(array);
int min=Min(array);
int result=max-min;


ShowArray(array);
Console.Write($"Сумма элементов стоящих на нечетных местах в масииве = {result}");
