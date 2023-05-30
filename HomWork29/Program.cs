// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[]arr = {1,2,5,7,19,6,1,33};
PrintArray(arr);

void PrintArray(int[]Coll)
{
    int count = Coll.Length;
    int possition = 0;
    while(possition < count)
    {
        Console.Write(Coll[possition]+",");
        possition++;
    }
}

