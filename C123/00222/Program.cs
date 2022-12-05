
// Math.Sqrt();

// task 21

Console.Clear();

Console.Write("Введите координату Х числа А: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y числа А: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х числа B: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y числа B: ");
double yb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между точек: {Math.Round(Math.Sqrt(Math.Pow(xa-xb, 2)+Math.Pow(ya-yb, 2)), 3)}");


Console.WriteLine($"Расстояние между точками: {Math.Round(result, 3)}"); // указать какое количество цифр после запятой в значении result
