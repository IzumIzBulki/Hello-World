// Task 41

Console.WriteLine("Вводите значения, если хотите остановить, введите 0");
int n = Convert.ToInt32(Console.ReadLine());
int Count = 0;
while (n != 0)
{n = Convert.ToInt32(Console.ReadLine());if ( n > 0) Count++;}
Console.Write($"Количество положительных чисел: {Count}");
