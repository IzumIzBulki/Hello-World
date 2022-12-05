Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0 && n % 3 == 0)
    Console.Write("yes");
else
    Console.Write("no");

if (n % 2 == 0 || n % 3 == 0)
    Console.Write("yes");
else
    Console.Write("no");