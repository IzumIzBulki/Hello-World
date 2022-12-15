// Task 50

Console.Clear();

int n = new Random().Next(3, 6);
int m = new Random().Next(3, 6);

int[,] matrix = new int[n, m];

Console.Write("Введите номер позиции по вертикали: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер позиции по горизонтали: ");
int y = Convert.ToInt32(Console.ReadLine());

void FillMatrix(int[,] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j]);
        }
        Console.WriteLine();
    }
}

void SearchByPosition(int x, int y)
{
    if (x > matrix.GetLength(0) || y > matrix.GetLength(1))
    {
        Console.WriteLine("Такого значения в массиве нет");
        return;
    }
    else
    {
        Console.WriteLine($"Наше значение: {matrix[x, y]}");
        return;
    }
}


FillMatrix(matrix);
SearchByPosition(x, y);