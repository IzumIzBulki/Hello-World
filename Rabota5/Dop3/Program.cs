// Dop3

Console.Clear();

Console.Write("Введите количество элементов по вертикали: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов по горизонтали: ");
int m = Convert.ToInt32(Console.ReadLine());
Char[,] matrix = new Char[n, m];




// void FillArray(char[,] matrix)
// {
// for (int i = 0; i < n; i++) 
// {
//     char examination = Convert.ToChar(new Random().Next(0x041, 0x05A));
//     for (int j = 0; j < i; j++)
//     {
//         if (examination == matrix[i, j]) {examination = Convert.ToChar(new Random().Next(0x030, 0x039)); j = 0;}
//     }
//     matrix[i, j] = examination;
// }
// }
















void FillMatrix(char[,] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int f = 0; f < matrix.GetLength(1); f++)
        {
            char examination = Convert.ToChar(new Random().Next(0x042, 0x042));
            for (int j = 0; j < f; j++)
            {
                if (examination == matrix[i, i]) { examination = Convert.ToChar(new Random().Next(0x057, 0x057)); j = 0; }
            }
            matrix[i, f] = examination;
            
            Console.Write(matrix[i, f]);
        }
        Console.WriteLine();
    }
}

FillMatrix(matrix);





