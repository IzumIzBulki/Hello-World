// task 3

Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());

if ( a >= 8 )
    Console.Write("warning");
else
if ( a == 1)
     Console.Write("Понедельник");
else
if ( a == 2)
    Console.Write("Вторник");
else
if ( a == 3)
    Console.Write("Среда");
else
if ( a == 4)
    Console.Write("Четверг");
else
if ( a == 5)
    Console.Write("Пятница");
else
if ( a == 6)
    Console.Write("Суббота");
else
    Console.Write("Воскресенье");

// task 5
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = n * (-1);
while (i <= n)
{
    Console.Write($"{i} "); // !!! интерполяция строк (заносит новое значение в туже строку с предыдущим)
    i = i + 1; // i++, i += 1
}


// task 5
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = (-1) * n; i <= n; i++)
    Console.Write(i + " ");


// task 7
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); // |2 147 000 000|
Console.Write(n % 10);
