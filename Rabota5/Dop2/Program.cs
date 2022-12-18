// Dop1 Транспонирование

Console.Clear();

int[,] matrix = new int[4, 10];
int count = 0;
int count2 = 0;

    for (int i = 0; i < 1; i++)
    {

        for (int f = 0; f < matrix.GetLength(1); f++)
        {
            if (f == 0)
            {
                matrix[i, f] = i + f + count;
                Console.Write($"{matrix[i, f]}\t");

            }
            else
            if (f == 1)
            {
                int m = f - 1;
                matrix[i, f] = i + f + m + count + i;
                Console.Write($"{matrix[i, f]}\t");

            }
            else
            if (f == 2)
            {
                int m = f - 1;
                int n = f - 2;
                matrix[i, f] = i + f + n + m + count + i + i;
                Console.Write($"{matrix[i, f]}\t");

            }
            else
            {
                if (f == matrix.GetLength(1)-1) count2 = -i;
                int m = f - 1;
                int n = f - 2;
                int y = f - 3;
                matrix[i, f] = i + f + n + m + y + count + count2 + i + i + i;
                Console.Write($"{matrix[i, f]}\t ");

            }
        }
        count2 = 0;
        count++;
        Console.WriteLine();
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        
        for (int f = 0; f < matrix.GetLength(1); f++)
        {
            if (i == 1 && f == 0) 
            {
            matrix[i, f] = matrix[i-1, f] + 2; 
            Console.Write($"{matrix[i, f]}\t ");
            }
            else
            if (f + 1 < matrix.GetLength(1))
            {
            matrix[i, f] = matrix[i-1, f+1] + 1;
            Console.Write($"{matrix[i, f]}\t ");
            }
            if (f + 1 >= matrix.GetLength(1))
            {
            matrix[i, f] = matrix[i-1, f] + f-matrix.GetLength(0)-i;
            Console.Write($"{matrix[i, f]}\t ");
            }
        }
        
        Console.WriteLine();
    }




