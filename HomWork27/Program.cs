// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
int num = Prompt("Введите число: ");
int index = GetCountNumbers(num);
GetSumNumbers(num, index);


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int GetCountNumbers(int Num)
{
    int i = 0;
    while (Num > 0)
    {
        Num /= 10;
        i++;
    }
    return i;
}

void GetSumNumbers(int Number, int count)
{
    int sum = 0;
    for(index =1; count < Number; index++)
    {
        sum += Number % 10;
        Number /= 10;
    }
    Console.WriteLine(sum);
}
