//task 36

Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[n];
int summ = 0;

for (int i = 0; i <= massiv.Length-1; i++)
{
    massiv[i] = new Random().Next(1, n+1);
    if (i % 2 != 0) summ = summ + massiv[i];
}
Console.WriteLine($"[{String.Join(", ", massiv)}]");
Console.WriteLine(summ);
