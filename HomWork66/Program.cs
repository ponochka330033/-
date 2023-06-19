// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Clear();

int numberM = Prompt("Введиче число M: ");
int numberN = Prompt("Введиче число N: ");
int result = 0;
int res = SumNumber(numberM, numberN);
Console.WriteLine($"{numberM}; {numberN} -> {res}");


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}


if (numberM > numberN)
{
    int temp = numberM;
    numberM = numberN;
    numberN = temp;
}

int SumNumber(int num1, int num2)
{
    if (num1 <= num2)
    {
        result = result + num1;
        SumNumber(num1 + 1, num2);
    }
    return result;
}
