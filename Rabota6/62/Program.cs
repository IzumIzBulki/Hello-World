// Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// 62

Console.Clear();

int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] Matrix = new int[size[0], size[1]];
int n = 1;

void FillMatrix(int[,] Matrix)
{
    for (int i = Matrix.GetLength(0); 0 < i; i--)
    {
        for (int g = 0; g < Matrix.GetLength(1); g++)
        {
            Matrix[i, g] = n;
            Console.Write($"{Matrix[i, g]}\t");
            n++;
        }
       Console.WriteLine(); 
    }
    
}

FillMatrix(Matrix);
