// dop DZ

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] result = new int[n];

for (int i = 0; i < n; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]
Console.WriteLine($"[{string.Join(", ", array)}]");
int k = Convert.ToInt32(Console.ReadLine());
k = k % n;
if (k > 0)
{
    for (int i = 0; i < k; i++)
        result[i] = array[array.Length - k + i];
    for (int i = 0; i < array.Length - k; i++)
        result[k + i] = array[i];
    Console.WriteLine($"[{string.Join(", ", result)}]");
}
else
{
    k = -k;
    for (int i = 0; i < k; i++)
        result[n - k + i] = array[i];
    for (int i = 0; i < array.Length - k; i++)
        result[i] = array[k + i];
    Console.WriteLine($"[{string.Join(", ", result)}]");
}

Console.Clear();
// Генерация случайных дробных чисел
//                                        * (end - begin) + begin
double number = new Random().NextDouble() * (50 - 10) + 10; // [0, 1]
// [begin; end]
Console.WriteLine(number);


// task 39

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11); // [1, 10]
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}


Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReverseArray(array);
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");



// task 40
Console.Write("Введите сторону а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону с: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a<b+c && b<c+a && c<a+b) 
    Console.Write("треугольник существует");
else
    Console.Write("треугольник не существует");


//task 42 перевод из  десятичной системы в двоичную 

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = String.Empty;
while (n > 0)
{
    result = Convert.ToString(n % 2) + result;
    n /= 2;
}
Console.WriteLine(result);

//task 44 ФИБОНАЧИ ДО N

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a0 = 0, a1 = 1, x;
for (int i = 0; i < n; i++)
{
    Console.Write($"{a0} ");
    x = a0 + a1;
    a0 = a1;
    a1 = x;
}

// поэлементная копия элемента

Console.Clear();
int[] a = {1, 2, 3, 4, 5};
int[] b = new int[a.Length];

for (int i = 0; i < a.Length; i++)
    b[i] = a[i];
    
b[0] = -1;
Console.WriteLine($"[{string.Join(", ", a)}]");
Console.WriteLine($"[{string.Join(", ", b)}]");
