Console.Clear();

int n = new Random().Next(10, 100); // рандом от (10 до 99)
int n1 = n / 10;
int n2 = n % 10;
Console.WriteLine($"Случайное: {n}");
if (n1 > n2)
    Console.Write(n1);
else
    Console.Write(n2);