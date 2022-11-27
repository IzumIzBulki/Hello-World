// Task #4

Console.Clear();

int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());


if (n1 > n2 && n1 > n3)   Console.Write ($"max = {n1}");
else
if (n2 > n3) Console.Write ($"max = {n2}");
else
    Console.Write ($"max = {n3}");



    