// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//[1,7] -> такого числа в массиве нет [1,7]-это позиция элемента 1 - строка, 7 - столбец

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int X = Prompt("Введите позицию строки элемента: ");
int Y = Prompt("Введите позицию столбца элемента: ");
int[,] array = GetArray(rows, columns, 1, 10);
PrintArray(array);
PositionElement(rows, columns, X, Y);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++) 
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PositionElement(int m, int n, int pos, int pos2)
{
    if(pos < 0 || pos > m || pos2 < 0 || pos2 > n)
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else
    {
         Console.WriteLine($"Значение элемента массива = [{pos}, {pos2}]");
    }
}
