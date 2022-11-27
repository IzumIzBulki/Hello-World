// Task 15

Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());

if ( n <= 5 && n > 0 || n == 1 ) Console.Write("Не выходной");
else
    if ( n == 7 || n == 6) Console.Write("Выходной");
    else
        Console.Write("введите правильное число");
