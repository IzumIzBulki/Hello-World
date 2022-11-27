// Task #6

Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
int Count = 0;
if (n <= 1) Console.Write("Слишком маленькое число, должно быть больше 1");
while ( Count < n )
{
    Count++;
    if ( Count % 2 == 0 ) Console.Write($"{Count},");
}
