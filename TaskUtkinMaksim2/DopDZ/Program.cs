// Дополнительное


Console.WriteLine("Вводите значения, если хотите остановить, введите 0");
int n = Convert.ToInt32(Console.ReadLine());
int Count2 = 0;
int Count3 = 0;

while (n != 0)
{
    Count2 = n;
    n = Convert.ToInt32(Console.ReadLine());
    if ( n > 0) Count3 = Count2;
}
Console.Write($"Наша цифра: {Count3}");



