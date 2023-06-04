// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = GetArray(4, 100, 1000);
PrintArray(array);
int count = ExamArr(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел - {count}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);

    }
    return res;
}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


int ExamArr (int[] arr)
{
    int exam = 0;
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i] % 2 == 0)
        {
        exam ++;
        }  
    }
    return exam;
}