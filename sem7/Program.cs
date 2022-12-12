

// // ввод массива в одну строку 

// string[] numbers = Console.ReadLine().Split(" ");

// foreach (string element in numbers)
//     Console.WriteLine(element);


// // доп к 6 семинару
// int n = Convert.ToInt32(Console.ReadLine());
// string[] numbers = Console.ReadLine().Split(" ");
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = int.Parse(numbers[i]);


// int countEven = 0, countOdd = 0;
// foreach (int element in array)
// {
//     if (element % 2 == 1)
//     {
//         Console.Write($"{element} ");
//         countEven++;
//     }
// }
// Console.WriteLine();
// foreach (int element in array)
// {
//     if (element % 2 == 0)
//     {
//         Console.Write($"{element} ");
//         countOdd++;
//     }
// }
// Console.WriteLine();
// if (countOdd > countEven)
//     Console.WriteLine("YES");
// else
//     Console.WriteLine("NO");




// гипотеза гольдбаха 

// int n = Convert.ToInt32(Console.ReadLine());
// int countDel = 0, i, j, k, m;
// for (i = 2; i <= n / 2; i++)
// {
//     countDel = 0;
//     for (j = 2; j <= i / 2; j++)
//     {
//         if (i % j == 0)
//             countDel++;
//     }
//     if (countDel == 0)
//     {
//         countDel = 0;
//         m = n - i;
//         for (k = 2; k <= (m + 1) / 2; k++)
//         {
//             if (m % k == 0)
//                 countDel++;
//         }
//         if (countDel == 0)
//         {
//             Console.WriteLine($"{i} {m}");
//             return;
//         }
//     }
// }

// task 46


// void InputMatrix(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
//             Console.Write($"{matrix[i, j]} \t"); //   \t табуляция, большие пробелы
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// string[] coord = Console.ReadLine().Split(" ");
// int row = int.Parse(coord[0]);
// int column = int.Parse(coord[1]);
// int[,] matrix = new int[row, column];
// InputMatrix(matrix);

// task 48 + 49


// void InputMatrix(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 1 && j % 2 == 1)
//             {
//                 matrix[i, j] = (i + j)*(i + j);   
//                 Console.Write($"{matrix[i, j]} \t");
//             }
//             else
//             {
//                 matrix[i, j] = (i + j); 
//                 Console.Write($"{matrix[i, j]} \t");
//             }
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
// int[,] matrix = new int[coord[0], coord[1]];
// InputMatrix(matrix);

// task 49

// void InputMatrix(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// void ReleaseMatrix(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 1 && j % 2 == 1)
//             {
//                 matrix[i, j] *= matrix[i, j];
//             }
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
// int[,] matrix = new int[coord[0], coord[1]];
// Console.WriteLine("Начальная матрица: ");
// InputMatrix(matrix);
// Console.WriteLine("Результат: ");
// ReleaseMatrix(matrix);


// task 51

// int summ = 0;
// void InputMatrix(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = (i + j);   
//             Console.Write($"{matrix[i, j]} \t");
//             if (i == j)
//             {
//                 summ = summ + matrix[i, j];
                
//             }
            
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine(summ);
// }

// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
// int[,] matrix = new int[coord[0], coord[1]];
// InputMatrix(matrix);

// task 51v2

// void InputMatrix(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// void ReleaseMatrix(int[, ] matrix)
// {
//     int result = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j && j == matrix.GetLength(1) - 1 && i == matrix.GetLength(0) - 1)
//             {
//                 result += matrix[i, j];
//                 Console.Write($"{matrix[i, j]} = ");
//             }
//             else if (i == j){
//                 result += matrix[i, j];
//                 Console.Write($"{matrix[i, j]} + ");
//             }
//         }
//     }
//     Console.Write(result);
// }

// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
// int[,] matrix = new int[coord[0], coord[1]];
// Console.WriteLine("Начальная матрица: ");
// InputMatrix(matrix);
// Console.Write("Результат: ");
// ReleaseMatrix(matrix);