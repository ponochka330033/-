// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = Prompt("Введите число b1: ");
double k1 = Prompt("Введите число k1: ");
double b2 = Prompt("Введите число b2: ");
double k2 = Prompt("Введите число k2: ");
double x = ValueX(b1, k1, b2, k2);
double y = ValueY(b2, k2, x);
Console.WriteLine($"Точка пересечени прямых: {x}, {y}");


double Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    double number = Convert.ToDouble(value);
    return number;
}

double ValueX(double b1, double k1, double b2, double k2)
{
    double X = (- b2 + b1) / (- k1 + k2);
    return X;
}

double ValueY(double b2, double k2, double x)
{
    double Y = k2 * x + b2;
    return Y;
}

