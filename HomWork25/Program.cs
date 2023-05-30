// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    int Number = int.Parse(Console.ReadLine()!);
    return Number;
}

int NumA = Prompt("Введите число A: ");
int NumB = Prompt("Введите число B: ");
double Degree = DegreeNum(NumA, NumB);
Console.WriteLine(Degree);

double DegreeNum(int num1, int num2)
{
    double degree = 0;
    if(num2 <= 0)
    {
        Console.WriteLine("Не натуральное число");
    }
    else
    {
        degree = Math.Pow(num1, num2);
    }
    return degree;
}

