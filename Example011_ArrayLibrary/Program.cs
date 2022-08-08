int[] array = new int[10];

a(array);
b(array);

void a(int[] collection)
{
    int Length = collection.Length;
    int i = 0;
    while (i < Length)
    {
       collection[i] = new Random().Next(1, 10);
       i++;
    }
}

void b(int[] collection)
{
    int Length = collection.Length;
    int i = 0;
    while (i < Length)
    {
        Console.WriteLine(collection[i]);
        i++;
    }
}
