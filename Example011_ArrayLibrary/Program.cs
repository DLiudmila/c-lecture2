int[] array = new int[10];

Insert(array);
Print(array);
int x = indexOf(array, 3);
Console.WriteLine("position="+x);



void Insert(int[] collection)
{
    int Length = collection.Length;
    int i = 0;
    while (i < Length)
    {
       collection[i] = new Random().Next(1, 10);
       i++;
    }
}

void Print(int[] collection)
{
    int Length = collection.Length;
    int i = 0;
    while (i < Length)
    {
        Console.WriteLine(collection[i]);
        i++;
    }
}

int indexOf(int[] array, int number)
{
    int Length = array.Length;
    int i = 0;
    int position = -1;
    while (i < Length)
    {
        if (array[i] == number)
        {
            position = i;
            break;
        }
        i++;
    }
    return position;
}
