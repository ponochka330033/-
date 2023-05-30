// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


string EnteringNumber(string message)
{
    Console.Clear();
    string Num = Console.ReadLine()!;
    return(Num);
}

string palindrome = EnteringNumber("Введите пятизначное число: ");
Palindrome (palindrome);


void Palindrome(string pal)
{
    int count = pal.Length;

    if (count == 5)
    {
        if (pal[0] == pal[4] && pal[1] == pal[3])
        {
            Console.WriteLine ("Палиндром");
        }
        else
        {
            Console.WriteLine ("Не палиндром");
        }
    }
    else
    {
        Console.WriteLine ("Ошибка ввода");
    }
}
