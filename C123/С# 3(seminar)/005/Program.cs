// task 14
Console.Clear();

Console.Write("Введите 1 число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 * n1 == n2 || n2 * n2 == n1 )
    Console.Write("yes");
else
    Console.Write("no");



