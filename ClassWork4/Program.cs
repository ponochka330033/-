// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
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
digitNumber(Num);

void digitNumber(int number)
{
    int i = 0;
    while (number > 0)
    {
        number /= 10;
        i++;
    }
    Console.WriteLine("Количество цифр в числе = " + i);
}