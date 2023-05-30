void FillArray(int[]array)
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = new Random().Next(0,2);
        index++;
    }
}

int[]arr = new int[8];
FillArray(arr);
PrintArray(arr);

void PrintArray(int[]Coll)
{
    int count = Coll.Length;
    int possition = 0;
    while(possition < count)
    {
        Console.Write(Coll[possition]+" ");
        possition++;
    }
}
