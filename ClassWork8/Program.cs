// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

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

void ExamArr (int[] arr)
{
    int exam = 0;
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i]>10 && arr[i]<99)
        {
        exam ++;
        // Console.WriteLine($"Такое число есть под номером {i+1} ");
        }
    }
    if (exam == 0)
        {
        Console.WriteLine($"Таких чисел нет в массиве ");
        }
    else
    {
        Console.WriteLine($"Количество таких элементов в массиве равно: {exam} ");
    }    
}

int[] array = GetArray(123, 0, 200);
PrintArray(array);
Console.WriteLine($"");
ExamArr(array);
// Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();

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

int [] array = GetArray(4, -10, 10);
PrintArray (array);

// foreach (int el in array)
// {
//         el= el*-1;
// }

// for (int i = 0; i<array.Length; i++)
// {
//     array[i]= array[i]*-1;
// }

Console.WriteLine();
PrintArray (array);
// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

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

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}

void ExamArr (int[] arr, int val)
{
    int exam = 0;
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i]==val)
        {
        exam = 1;
        Console.WriteLine($"Такое число есть под номером {i+1} ");
        }
    }
    if (exam == 0)
        {
        Console.WriteLine($"Такое числоа нет в массиве ");
        }

}

int value = Prompt("Введите искомое число: ");
int[] array = GetArray(30, -10, 10);
PrintArray(array);
ExamArr(array, value);
Анатолий 21:29
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
