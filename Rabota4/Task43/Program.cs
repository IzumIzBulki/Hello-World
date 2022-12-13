//Task 43

Console.Clear();
Console.Write("Введите значение b1: ");
Double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
Double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
Double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
Double k2 = Convert.ToDouble(Console.ReadLine());

Double y = 0;
Double x = 0;
if ( k1 == k2) {Console.Write("Прямые не пересекаются, они параллельные"); return;}
x = (-b1+b2)/(k1-k2);   
y = k1 * x + b1;
if (x == -0) x = 0;
Console.Write($"Координаты точки пересечения прямыъ: ({x}; {y})");


