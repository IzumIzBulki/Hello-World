Console.Clear();
int[] array = {1, 3, 112, 5, 77, 112};

int n = array.Length;
int find = 112;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}