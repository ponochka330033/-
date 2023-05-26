//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int Number = int.Parse (userInput);
int Num = 0;

if (Number >= 100)
{
    while (Number > 999)
    {
        Number = Number / 10;
    }
    Num = Number % 10;
    Console.WriteLine($"{Number} -> {Num}");
}
else 
{
    Console.WriteLine ("Третьей цифры нет");
}

