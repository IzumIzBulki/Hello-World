// Dop1 Транспонирование

Console.Clear();

Console.Write("Введите количество элементов по вертикали: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов по горизонтали: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

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

void TransportArray(int[,] matrix)
{
    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
        for (int f = 0; f < matrix.GetLength(0) / 2; f++)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int temp = matrix[0 + f, i];
                matrix[0 + f, i] = matrix[matrix.GetLength(0) - 1 - f, i];
                matrix[matrix.GetLength(0) - 1 - f, i] = temp;
            }
        }
    }
    else
    {
        for (int f = 0; f < matrix.GetLength(0) / 2; f++)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int temp = matrix[0 + f, i];
                matrix[0 + f, i] = matrix[matrix.GetLength(1) - 1 - f, i];
                matrix[matrix.GetLength(1) - 1 - f, i] = temp;
            }
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int f = 0; f < matrix.GetLength(1); f++)
            Console.Write(matrix[i, f]);
        Console.WriteLine();
    }
}

Console.WriteLine("Изначальная матрица: ");
FillMatrix(matrix);
Console.WriteLine("Матрица после перестановки: ");
TransportArray(matrix);




