Console.Write("Введите размер матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
int j = 0;
int f = 0;

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int f = 0; f < matrix.GetLength(1); f++) Console.Write($"{matrix[i, f]}\t");
        Console.WriteLine();
    }
}

void CreateMatrix(int[,] matrix)
{

    for (int i = 1; i <= matrix.GetLength(0) * matrix.GetLength(1); i++)
    {
        matrix[j, f] = i;
        if (j <= f + 1 && j + f < matrix.GetLength(1) - 1) f++;
        else if (j < f && j + f >= matrix.GetLength(1) - 1) j++;
        else if (j + 1 >= f && j + f > matrix.GetLength(1) - 1) f--;
        else j--;
    }
}


CreateMatrix(matrix);
FillMatrix(matrix);