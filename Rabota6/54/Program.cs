// 54

Console.Clear();

int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];


void FillMatrix(int[,] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int f = 0; f < matrix.GetLength(1); f++)
        {
            matrix[i, f] = new Random().Next(1, 10);
            Console.Write(matrix[i, f]);
        }
        Console.WriteLine();
    }
}

void SortingMatrix(int[,] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int f = 0; f < matrix.GetLength(1); f++)
        {
            for (int g = 0; g < matrix.GetLength(1); g++)
            {
                for (int c = 0; c < matrix.GetLength(1)-1; c++)
                {
                    if (matrix[i, c]*-1 > matrix[i, c + 1]*-1)
                    {
                        int temp = matrix[i, c];
                        matrix[i, c] = matrix[i, c + 1];
                        matrix[i, c + 1] = temp;
                    }
                }
            }
            Console.Write(matrix[i, f]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Начальная матрица");
FillMatrix(matrix);
Console.WriteLine("Отсортированная матрица");
SortingMatrix(matrix);

