int[] array = {5, 56, 7, 98, 45, 34, 19, 43, 85, 7};
int n = array.Length;

int find = 7;
int i = 0;

while (i < n)
{
    if (array[i] == find)
    {
        Console.WriteLine(i);
    }
     i++;
   
}

