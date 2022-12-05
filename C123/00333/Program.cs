// Task 22

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i <= n)
{
    Console.Write($"{Math.Pow(i, 2)} "); 
    i = i + 1;
}



// task 22

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.Write($"{i * i} ");
