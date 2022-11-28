// Task 13
Console.Clear();


int n = Convert.ToInt32(Console.ReadLine());

string s = n.ToString();

int v = Convert.ToInt32((n / Math.Pow(10, s.Length-3))%10);
if (v == 0) Console.WriteLine("Введите 3ех значное число");
else
    Console.WriteLine(v);


  
