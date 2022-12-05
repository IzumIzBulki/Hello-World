// DopDZ
Console.Clear();


int n = Convert.ToInt32(Console.ReadLine());
int n1 = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int t = 0;
int k = -1;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, n+1);
}
Console.WriteLine($"[{string.Join(", ", array)}]");

if (n1 > 0)
{
    for (int i = array.Length-n1; i <= array.Length-1; i++)
        {
            int j = i;
            k++;
            while ( j > k)
            {
                t = array[j];
                array[j] = array[j-1];
                array[j-1] = t;        
                j--;
            }
        }
}
else
{
    n1 = n1 * -1;
    for (int i = 0; i < n1; i++)
        {
            
            k++;
            int j = n1-1-k;
            while ( j < array.Length-1-k)
            {
                t = array[j];
                array[j] = array[j+1];
                array[j+1] = t;        
                j++;
            }
        }
}
Console.WriteLine($"[{string.Join(", ", array)}]");

































// if (n1 > 0)
//     for (int j = 0; j <= n1-1; j++)
//         {
//             t = array[j];
//             array[j] = array[array.Length-n1+j]; 
//             array[array.Length-n1+j] = t;
//         }
//     if (n - n1 == 2)
//         {
//             t = array[array.Length-1];
//             array[array.Length-1] = array[array.Length-2]; 
//             array[array.Length-2] = t;
//         }
// if (n < 0)
// {
//     n1 = n1*-1;
//     for (int j = 0; j <= n1-1; j++)
//     {
//         t = array[n1-1-j];
//         array[n1-1-j] = array[array.Length-1-j];
//         array[array.Length-1-j] = t;
//     }
//     if (n - n1 == 2)
//     {
//         t = array[0];
//         array[0] = array[1]; 
//         array[1] = t;
//     }
// }
// Console.WriteLine($"[{string.Join(", ", array)}]");
