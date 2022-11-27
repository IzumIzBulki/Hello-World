// Task 10

Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());

if ( n >= 1000 || n <= 99) Console.Write("Введите техзначное число");
else
    Console.Write( ( n / 10 ) % 10) ;
