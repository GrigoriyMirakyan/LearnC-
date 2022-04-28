int[] array = { 1, 5, 65, 8, 45, 4, 98, 2, 7 };

int n = array.Length;
int find = 98;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}