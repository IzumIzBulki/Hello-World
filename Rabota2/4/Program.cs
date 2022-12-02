// tack 4
Console.Clear();
Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int n4 = 0;
n4 = n1;
for (int i = 1; i < n2; i++)
{
    n1=n1*n4;
}
Console.Write("Ответ: ");
Console.WriteLine($"{n1}");