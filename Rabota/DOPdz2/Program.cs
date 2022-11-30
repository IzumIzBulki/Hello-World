// DOPdz2

Console.Clear();
Console.Write("Введите количество кустов: "); 
int n = Convert.ToInt32(Console.ReadLine());
if (n < 3) 
{ 
    Console.Write("Посадите больше 2ух кустов ");
    return;
}
int[] mod = new int[n];
int count = mod.Length;
int max = 0;
int summ = 0;
Console.Write("Наши ягоды: "); 
for (int i = 0; i < n; i++)
{
    int x = new Random().Next(0, n+1);
    mod[i] = x;
    Console.Write(mod[i]);  
}
for (int j = 0; j < mod.Length; j++)
{
    if (j != 0 && j !=count-1)
        summ = mod[j-1] + mod[j+1] + mod[j];
        if (summ > max) max = summ;
}
Console.WriteLine(" "); 
Console.Write($"Максимальное число ягод: {max}");  
