Console.Clear();

// 
Console.Clear();
Console.Write("Введите кол-во элементов: ");
string? n = Console.ReadLine();  // ? принять предупреждение, string только для букв 
Console.WriteLine(int.Parse(n[0].ToString()) * 2);  // перевод из string в int если ввести цифру в string


//

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ", array)}]");  // вывод массива созданного в цикле for


// function
// Найти максимум из 2-х чисел

int numbersMax(int n, int m)
{
    if (n > m)
        return n;
    return m;
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numbersMax(n, m));  // покажет число которое вернет return в if


// процедура

void numbersMax(ref int a)
{
    a = a + 10;
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
numbersMax(ref n);  // без ref работать не будет, а с ref мы отправляем наш n в void изменяет его и возвращает 
Console.WriteLine(n);


// сумма чисел от 1 до n через математику (прогрессия)

Console.Clear();
Console.Write("Введите число: ");
double n = Convert.ToDouble(Console.ReadLine()); // double нужен что бы цифры не округлялись через тип int
Console.WriteLine((1 + n) / 2 * n);

// Task 26
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (n>0)
{
    n  /= 10;
    sum++;
}
Console.Write($"{sum}");



// Task 28
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int sum = 1;
for (int i = 2; i <= n; i++)
    sum = sum * i;
Console.WriteLine(sum);



// Task 30


Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 2);
Console.WriteLine($"[{string.Join(", ", array)}]");


