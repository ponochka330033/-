//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.Write(message);
    int Num = int.Parse(Console.ReadLine()!);
    return Num;
}

int x1 = Prompt("Введите координату x1: ");
int y1 = Prompt("Введите координату y1: ");
int z1 = Prompt("Введите координату z1: ");

int x2 = Prompt("Введите координату x2: ");
int y2 = Prompt("Введите координату y2: ");
int z2 = Prompt("Введите координату z2: ");

double distance = GetDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(distance);

static double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int resultx = x2 - x1;
    int resulty = y2 - y1;
    int resultz = z2 - z1;
    double distance = Math.Sqrt(resultx * resultx + resulty * resulty + resultz * resultz);
    return distance;
}
