// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)


// 60

Console.Clear();

int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,,] Matrix = new int[size[0], size[1], size[2]];
int n = 11;

void FillMatrix(int[,,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int f = 0; f < Matrix.GetLength(1); f++)
        {

            for (int g = 0; g < Matrix.GetLength(2); g++)
            {

                Matrix[i, f, g] = n;
                Console.Write($"{Matrix[i, f, g]}({i}.{f}.{g})\t");
                n++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();

    }
}

FillMatrix(Matrix);