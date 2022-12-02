// DopDZ
Console.Clear();


int n = Convert.ToInt32(Console.ReadLine());
int n1 = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int t = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, n+1);
}
Console.WriteLine($"[{string.Join(", ", array)}]");


if (n1 < 0 && n/2<n1*-1)
{
    n1 = n1*-1;
    for (int k = 0; k <= n1-1; k++)
    {
        t = array[k];
        array[k] = array[k+n1]; 
        array[k+n1] = t;
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
    return;
}
// else
    // if (n1 < 0) n1 = n1*-1;
    // for (int j = 0; j <= n1-1; j++)
    // {
    //     t = array[j];
    //     array[j] = array[array.Length-n1+j]; 
    //     array[array.Length-n1+j] = t;
    // }
    // if (n - n1 == 2)
    // {
    //     t = array[array.Length-1];
    //     array[array.Length-1] = array[array.Length-2]; 
    //     array[array.Length-2] = t;
    // }

Console.WriteLine($"[{string.Join(", ", array)}]");