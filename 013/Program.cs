// Task 13
Console.Clear();


int n = Convert.ToInt32(Console.ReadLine());
// if (n < 0) n = n * -1;
// string s = n.ToString();

// int v = Convert.ToInt32((n / Math.Pow(10, s.Length-3))%10);
// if (v == 0) Console.WriteLine("Введите 3ех значное число");
// else
//     Console.WriteLine(v);

if (n < 0) n = n * -1;
else
if (n < 99) 
    Console.WriteLine("введи");
else
while (n > 1000)
    n /=10;

Console.WriteLine(n % 10);


  
