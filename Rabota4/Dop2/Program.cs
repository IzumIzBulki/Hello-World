// Dop 1

Console.Clear();
Console.WriteLine("Введите через пробел, последовательно, координаты вершин х1, у1, х2, у2, х3, у3");
Double S = 0;
string[] numbers = Console.ReadLine().Split(" ");
Double[] xyz = new Double[6];
for (int i = 0; i < xyz.Length; i++)
    xyz[i] = Double.Parse(numbers[i]);

Console.Write($"[{xyz[0]}, {xyz[1]}] [{xyz[2]}, {xyz[3]}] [{xyz[4]}, {xyz[5]}]");

if (((xyz[2]-xyz[0])*(xyz[5]-xyz[1])-(xyz[4]-xyz[0])*(xyz[3]-xyz[1]))<0)
    S = ((xyz[2]-xyz[0])*(xyz[5]-xyz[1])-(xyz[4]-xyz[0])*(xyz[3]-xyz[1]))*-1*1/2;
else
    S = ((xyz[2]-xyz[0])*(xyz[5]-xyz[1])-(xyz[4]-xyz[0])*(xyz[3]-xyz[1]))*1/2;

Console.WriteLine();
if (S == 0)  {Console.WriteLine("Треугольника с такими координатами не существует"); return;}
Console.WriteLine($"Площадь заданного треугольника: {S}");