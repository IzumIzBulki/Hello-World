// 58


Console.Clear();

int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] FerstMatrix = new int[size[0], size[1]];
int[,] SecondMatrix = new int[size[0], size[1]];
int summ = 0;

void FillMatrix(int[,] FerstMatrix)
{
    for (int i = 0; i < FerstMatrix.GetLength(0); i++)
    {
        for (int f = 0; f < FerstMatrix.GetLength(1); f++)
        {
            FerstMatrix[i, f] = new Random().Next(1, 10);
            Console.Write($"{FerstMatrix[i, f]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Первая матрица");
FillMatrix(FerstMatrix);
Console.WriteLine("Вторая матрица");
FillMatrix(SecondMatrix);
Console.WriteLine("Их произведение");

for (int j = 0; j < FerstMatrix.GetLength(0); j++)
{
    for (int g = 0; g < FerstMatrix.GetLength(1); g++)
    {
        summ = SecondMatrix[j, g] * FerstMatrix[j, g];
        Console.Write($"{summ}\t");
    }
    Console.WriteLine();
}






