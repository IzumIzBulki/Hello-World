Console.Clear();

// // dop 1 транспонирование с вводом матрици в одну строку 

// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = numbers[j];
//         Console.Write($"{matrix[i, j]} \t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// for (int i = 0; i < matrix.GetLength(0) / 2; i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int temp = matrix[i, j];
//         matrix[i, j] = matrix[matrix.GetLength(0) - i - 1, j];
//         matrix[matrix.GetLength(0) - i - 1, j] = temp;
//     }
// }

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//         Console.Write($"{matrix[i, j]} \t");
//     Console.WriteLine();
// }


// // dop 1 v2 транспонирование 

// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
//         Console.Write($"{matrix[i, j]} \t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// for (int i = 0; i < matrix.GetLength(0) / 2; i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int temp = matrix[i, j];
//         matrix[i, j] = matrix[matrix.GetLength(0) - i - 1, j];
//         matrix[matrix.GetLength(0) - i - 1, j] = temp;
//     }
// }

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//         Console.Write($"{matrix[i, j]} \t");
//     Console.WriteLine();
// }



// // Доп 2 миша и негатив 


// void InputMatrixFirst(int[,] matrixFirst)
// {
//     for (int i = 0; i < matrixFirst.GetLength(0); i++)
//     {
//         string? input = Convert.ToString(Console.ReadLine());
//         for (int j = 0; j < input.Length; j++)
//         {
//             matrixFirst[i, j] = input[j];
//         }
//     }
// }
 
 
// void InputMatrixSecond(int[,] matrixSecond)
// {
//     for (int i = 0; i < matrixSecond.GetLength(0); i++)
//     {
//         string? input = Console.ReadLine();
//         for (int j = 0; j < input.Length; j++)
//         {
//             matrixSecond[i, j] = input[j];
//         }
//     }
// }
 
 
// void ReleaseMatrix(int[,] matrixFirst, int[,] matrixSecond)
// {
//     int count = 0;
//     for (int i = 0; i < matrixSecond.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixSecond.GetLength(1); j++)
//         {
//             if (matrixFirst[i, j] == matrixSecond[i, j])
//                 count++;
//         }
//     }
//     Console.WriteLine($"{count}");
// }
 
 
// Console.Clear();
// Console.Write("Введите кол-во строк и столбцов: ");
// string[] num = Console.ReadLine().Split(' '); // ввод двух чисел в одну строку
// int n = int.Parse(num[0]);
// int m = int.Parse(num[1]);
// int[,] matrixFirst = new int[n, m];
// int[,] matrixSecond = new int[n, m];
// InputMatrixFirst(matrixFirst);
// Console.WriteLine();
// InputMatrixSecond(matrixSecond);
// ReleaseMatrix(matrixFirst, matrixSecond);


// // рекурсия, сумма цифр без суммы цифр

// // v1 через вайл 
// Console.Clear();
// Console.Write("Введите числа: ");
// int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int a = numbers[0], b = numbers[1];
// while (a != 0)
// {
//     a--;
//     b++;
// }
// Console.WriteLine(b);



// // v1 через цикл
// int rec(int a, int b)
// {
//     if (a == 0)
//         return b;
//     return rec(a - 1, b + 1);
// }


// Console.Clear();
// Console.Write("Введите числа: ");
// int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// Console.WriteLine(rec(numbers[0], numbers[1]));


// // v1 сумма цифр до ввода цифры 0

// int sum()
// {
//     int x = Convert.ToInt32(Console.ReadLine());
//     if (x == 0)
//         return 0;
//     return sum() + x;
// }


// Console.Clear();
// Console.WriteLine(sum());


// // v2  сумма цифр до ввода цифры 0

// void sum(int res)
// {
//     int x = Convert.ToInt32(Console.ReadLine());
//     if (x == 0)
//         Console.WriteLine(res);
//     else
//     {
//         res += x;
//         sum(res);
//     }
// }


// Console.Clear();
// int res = 0;
// sum(res);



// // v1 числа от 1 до N через рекурсию

// string rec(int n)
// {
//     if (n == 1)
//         return "1 ";
//     return rec(n - 1) + $"{n} ";
// }


// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));


// // v2 числа от 1 до N через рекурсию

// void rec(int n)
// {
//     if (n == 1)
//         Console.Write("1 ");
//     else if (n > 1)
//     {
//         Console.Write($"{n} ");   // от N до 1
//         rec(n - 1);
//        // Console.Write($"{n} ");   // от 1 до N
//     }
// }


// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// rec(n);



// 65 v1


// string rec(int a, int b)
// {
//     if (a == b)
//         return $"{a} ";
//     return rec(a, b - 1) + $"{b} ";
// }


// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n, m));

// 65 v2

// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());

// void rec(int n, int m)
// {
//     if (n == m)
//         Console.Write(m);
//     else 
//     {
        
//         rec(n, m - 1);
//         Console.Write($" {m}"); 
//     }
// }

// rec(n, m);


// 67 v1 сумма от цифр которые я ввожу через рекурсию

// int rec(int a)
// {
//     if (a / 10 == 0 || a < 10 || a % 10 == a)
//         return a;
//     return rec(a / 10) + a % 10;
// }


// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));


// // 67 v2 с умножением рекурсия

// int rec(int a)
// {
//     if (a / 10 == 0)
//         return a;
//     return rec(a / 10) * (a % 10);
// }

// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));


// 69  число в степень, рекурсия


int rec(int a, int b)
{
    if (b == 0 && a != 0)
        return 1;
    return rec(a, b - 1) * a;
}
Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(a, b));


















