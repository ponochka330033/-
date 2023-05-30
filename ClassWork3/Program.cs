
//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int number = Convert.ToInt32(value);
    return number;
}
int Num = Prompt("Введите число: ");
int composition = Composition(Num);
Console.WriteLine(composition);

int Composition(int num)
{
    int comp = 1;
    for (int i = 1; i <= num; i++)
    {
        comp = comp * i;
        Console.Write(comp + " ");
    }
    return comp;
}