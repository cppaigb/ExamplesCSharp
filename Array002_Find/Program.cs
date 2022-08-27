int[] array = { 13, 88, 31, 499, 45, 67, 7, 88 };

int n = array.Length;

int find = 88;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }

    // index = index + 1
    index++;
}
