//66


Console.Clear();

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n >= m) { Console.Write($"Второе число должно быть больше первого ({n})"); return; }

int summ2 = 0;

int Summ(int n, int m, int summ2)
{
    if (n > m) return summ2;
    { return Summ(n + 1, m, summ2 = summ2 + n); }
}

Console.Write(Summ(n, m, summ2));