// Dop1

Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());

int n1 = n / 2;
int n2 = n - n1;
int division = 0;
Console.WriteLine($"{n2} ^ {n1}");
for (int i = 0; i < n / 2 ; i++)
{
    division = 0;
    for (int j = 2; j <= n/2+1; j++)
    {
        if (n1 % j != 0 && n2 % j != 0  )
        {
            division++;
                if (division == n/2-1)
                {
                    if (n1 == 2 || n1 == 3 || n1 == 5 || n1 % 3 != 0 )
                    {
                        Console.WriteLine($"{n2} и {n1}");
                        return;
                    }
                }
        }
            
    }
    n1++;
    n2--;
}









