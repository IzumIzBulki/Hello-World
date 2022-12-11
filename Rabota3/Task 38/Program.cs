//task 36

Console.Clear();
Console.Write("Задайте длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Double[] massiv = new Double[n];
Double min = Double.MaxValue;
Double max = 0;


for (int i = 0; i <= massiv.Length - 1; i++)
{
    massiv[i] = Math.Round(new Random().NextDouble() * 1000, 2); // [0, 1000] или как на семинаре new Random().NextDouble()*(50-10)+10; 
    if (min > massiv[i])
        min = massiv[i];
    else
    if (max < massiv[i])
        max = massiv[i];
}

Console.WriteLine($"[{String.Join(" | ", massiv)}]");
Console.WriteLine($"Разнима между max и min значением: {Math.Round(max - min, 2)}");