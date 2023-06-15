//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


int m = Prompt("Введите количество строк массива: ");
int n = Prompt("Введите количество столбцов массива: ");
double[,] matrix = new double[m,n];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void FillArray(double[,] result)
{
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().NextDouble() *10;
        }
    }
}

void PrintArray(double[,] result)
{
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write($"{result[i,j]} ");
        }
        Console.WriteLine();
    }
}
