//task 34

Console.Clear();
Console.Write("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[n];
int summ = 0;

for (int i = 0; i <= massiv.Length - 1; i++)
{
    massiv[i] = new Random().Next(100, 999);
    if (massiv[i] % 2 == 0) summ++;
}
Console.WriteLine($"[{String.Join(", ", massiv)}]");
Console.WriteLine($"Колличество цифр, кратных двум: {summ}");