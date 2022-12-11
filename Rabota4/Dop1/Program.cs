// Dop 1

Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
Char[] array = new Char[n];
int count = 0;

for (int i = 0; i < n; i++) 
{
    char examination = Convert.ToChar(new Random().Next(0x041, 0x05A));
    for (int j = 0; j < i; j++)
    {
        if (examination == array[j]) {examination = Convert.ToChar(new Random().Next(0x030, 0x039)); j = 0;}
    }
    array[i] = examination;
}

Console.Write(array);
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n-1; j++)
    {
        char t = array[j];
        array[j] = array[j+1];
        array[j+1] = t;
        count++;
        if(count >= (n*(n-1))) return;
            Console.WriteLine(array);
    }
}


