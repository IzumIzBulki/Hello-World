Console.Clear();

void FillArray(int[] collection){
    int n = collection.Length;
    int index = 0;
    while (index < n)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] Col){
    int count = Col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(Col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}




int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 4);

Console.WriteLine(pos);

