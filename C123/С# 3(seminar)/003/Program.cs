// task 11
Console.Clear();

Console.Write("Введите 1 число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число: ");
int n2 = Convert.ToInt32(Console.ReadLine());



if (n1 % n2 == 0)
    Console.Write("кратное");
else
    Console.Write("нет");

 Console.Write(n1 % n2);
