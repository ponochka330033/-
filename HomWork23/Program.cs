// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    int Number = int.Parse(Console.ReadLine()!);
    return Number;
}

int Num = Prompt("Введите число: ");
tableCubes(Num);

void tableCubes(int number)
{
    int i = 1;
    while (i <= number)
    {
        Console.WriteLine ($"{number} -> {Math.Pow(i, 3)}");
        i++;
    }
}