// 68
Console.Clear();
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());




int ackermann(int n, int m)
{
    if (n == 0) return m+1;
    else if (m == 0) return ackermann(n-1, 1);
    else return ackermann(n-1, ackermann(n, m-1));
}

Console.Write(ackermann(n, m));
