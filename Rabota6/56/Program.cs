// 56

Console.Clear();

int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int max = 0;
int number = 0;

void FillMatrix(int[,] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int f = 0; f < matrix.GetLength(1); f++)
        {
            matrix[i, f] = new Random().Next(1, 10);
            Console.Write(matrix[i, f]);
            sum = sum + matrix[i, f];
        }
        if (sum > max) {max = sum; number = i;}
        Console.WriteLine();
    }
    Console.WriteLine($"Максимальная сумма строки: {max} на строке: {number+1}");
}




FillMatrix(matrix);