
// task 27

Console.Clear();

Console.Write("Введите число: ");
string? n = Console.ReadLine();
int summ = 0;
for (int i = 0; i < n.Length; i++)
{
    summ = summ + int.Parse(n[i].ToString());
}
Console.WriteLine($"Сумма чисел: {summ}");
