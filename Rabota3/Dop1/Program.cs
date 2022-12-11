// Dop1

// Console.Clear();

// int n = Convert.ToInt32(Console.ReadLine());

// int n1 = n / 2;
// int n2 = n - n1;
// int division = 0;
// Console.WriteLine($"{n2} ^ {n1}");
// for (int i = 0; i <= n / 2 ; i++)
// {
//     division = 0;
//     for (int j = 2; j <= n/2+1; j++)
//     {
//         if (n1 % j != 0 && n2 % j != 0  )
//         {
//             division++;
//                 if (division == n/2-1)
//                 {
//                     if (n1 == 2 || n1 == 3 || n1 == 5 || n1 % 3 != 0 )
//                     {
//                         Console.WriteLine($"{n2} и {n1}");
//                         return;
//                     }

//                 }
//         }

//     }
//     n1++;
//     n2--;
// }



// int n = Convert.ToInt32(Console.ReadLine());


//     for (int i = 4; i <= n; i++)  // 10
//     {
//         int count = 0;
//         for (int j = 1; j <= i; j++)
//         {
//             if (i % j == 0) count++; //1 2 
//         }
//         if (count <= 2)
//         {
//             Console.WriteLine($"{i}");
//             return ;
//         }
//     }


// for (int a = n; a >= 4; a--)  
// {
//     // Console.WriteLine($"i: {i}");
//     int count2 = 0;
//     for (int j = a; j >= 1; j--)
//     {
//         // Console.WriteLine($"j: {j}");
//         if (a % j == 0)
//         {
//         count2++;
//         // Console.WriteLine($"count: {count}");
//         // if (count > 2 ) 
//         // continue;
//         }
//     }
//     if (count2 <= 2 )
//         {
//             Console.WriteLine($"{a}");
//             return;
//         }
// }





public static class Task0323
{
    public static void Main()
    {GetInputData(out var n);
    var result = Solve(n);
    PrintResult(n, result);}

    private static void GetInputData(out int n){n = int.Parse(Console.ReadLine());}

    public static int Solve(int n)
    {for (var i = 2; i <= n / 2; i++){if (IsPrime(i) && IsPrime(n - i)) return i;}
    return 0;}

    private static void PrintResult(int n, int p){Console.WriteLine($"{p} {n - p}");}

    private static bool IsPrime(int n)
    {for (var i = 2; i <= Math.Sqrt(n); i++) if (n % i == 0) return false;
    return true;}
}


