// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();
int[] array = GetArray(5, 1, 51);
PrintArray(array);
int Max = MaxElement(array);
int Min = MinElement(array);
int result = DiffElements(Max, Min);
Console.WriteLine();
Console.WriteLine($"Максимальный элемент - {Max}");
Console.WriteLine($"Минимальный элемент - {Min}");
Console.WriteLine($"Разница между max и min - {result}");


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

int MaxElement (int[] arr)
{
    int maxValue = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > maxValue)
        {
            maxValue = arr[i];
        }
    }
    return maxValue;
}

int MinElement (int[] arr)
{
    int minValue = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < minValue)
        {
            minValue = arr[i];
        }
    }
    return minValue;
}

int DiffElements(int max, int min)
{
    int diff = max - min;
    return diff;
}