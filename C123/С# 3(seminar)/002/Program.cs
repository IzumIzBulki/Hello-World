// task 11
Console.Clear();
int n = new Random().Next(100, 1000); // [100, 999]
Console.WriteLine($"Случайное число: {n}");
int n1 = n / 100;
int n3 = n % 10;
Console.Write(n1);
Console.Write(n3);
