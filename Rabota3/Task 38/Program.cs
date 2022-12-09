//task 36

Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[n];
int min = n+1;
int max = 0;


for (int i = 0; i <= massiv.Length-1; i++)
{
    massiv[i] = new Random().Next(1, n+1);
    if(min > massiv[i])
        min = massiv[i];
    else
    if(max < massiv[i]) 
        max = massiv[i];
}

Console.WriteLine($"[{String.Join(", ", massiv)}]");
Console.WriteLine(max - min);