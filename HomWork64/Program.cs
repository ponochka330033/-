// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int number = Prompt("Введиче число: ");
int i = number;


void NaturalNumber(int number, int count)
{
    if (count >= 1)
    {
        Console.Write($"{count} ");
        NaturalNumber(number, count - 1);
    }
}

NaturalNumber(number, i);
