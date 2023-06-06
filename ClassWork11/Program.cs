// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10

Console.Clear ();

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}

int[] CreateRandomMassive(int val)
{
    // int [] array = new int [8];
    int [] array = new int [val];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);  // генератор [a,b)
        // Console.Write (array[i]+" ");
    }
    return array;
}

void PrintMassive(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write (array[i]+" ");
    }
    Console.WriteLine ();
}

int val = Prompt("Введите количество элементов массива: ");
int[] origin = CreateRandomMassive(val);

int[] copy = new int[val];
for (int i=0; i<val; i++)
{
    copy [i] = origin [i];
}

PrintMassive(origin);
Console.WriteLine ("----------- ");
PrintMassive(copy);


int Reader()
{
    Console.WriteLine("enter your number: ");
    if (int.TryParse(Console.ReadLine(), out int num) == false || num < 0)
    {
        num = -1;
        return num;
    }
    else
    {
        return num;
    }
}

int CountDifiner (int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 2;
        count++;
    }
    return count;
}

int[] BinaryNumConverter (int num, int count)
{
    int[] binaryNum = new int[count];
    for (int i = count - 1; i >= 0; i--)
    {
        int temp = num % 2;
        num /= 2;
        binaryNum[i] = temp;
    }
    return binaryNum;
}

void PrintBinary (int[] binary)
{
    for (int i = 0; i < binary.Length; i++)
    {
        Console.Write(binary[i]);
    }
}


int num = Reader();
switch (num)
{
    case -1:
        Console.WriteLine("invalid number format");
        break;
    default:
        int count = CountDifiner(num);
        PrintBinary(BinaryNumConverter(num, count));
         break;
}