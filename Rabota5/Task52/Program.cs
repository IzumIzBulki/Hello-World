// Task 52

Console.Clear();

int n = new Random().Next(3, 6);
int m = new Random().Next(3, 6);
int[,] matrix = new int[n, m];
double summ = 0;

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


double SummArray(int[,] array)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        summ = 0;
        for (int f = 0; f < matrix.GetLength(0); f++)
        {
            summ = summ + matrix[f, i];
        }
        Console.WriteLine($"Сумма вертикали №{i+1}: {Math.Round(summ/matrix.GetLength(0), 2)}");
    }
    return summ;
}



FillMatrix(matrix);
Console.WriteLine();
SummArray(matrix);
