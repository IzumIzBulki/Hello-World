// Task47

Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

Double[, ] matrix = new Double[n, m];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().NextDouble()*100;
        Console.Write($"{Math.Round(matrix[i, j], 2)} \t");
    }
    Console.WriteLine();
}
