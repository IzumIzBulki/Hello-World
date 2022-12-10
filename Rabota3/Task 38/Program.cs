//task 36

Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
Double[] massiv = new Double[n];
Double min = n + 1;
Double max = 0;


for (int i = 0; i <= massiv.Length - 1; i++)
{
    massiv[i] = Math.Round(Convert.ToDouble(new Random().NextDouble()) * 10, 2);
    if (min > massiv[i])
        min = massiv[i];
    else
    if (max < massiv[i])
        max = massiv[i];
}

Console.WriteLine($"[{String.Join(" | ", massiv)}]");
Console.WriteLine(Math.Round(max - min, 2));