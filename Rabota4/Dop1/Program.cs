// Dop 1

Console.Clear();

Console.Write("Введите количество требуемых букв для перестановки: ");

int n = Convert.ToInt32(Console.ReadLine());
Char[] array = new Char[n];
int count = 0;

void FillArray(char[] massiv)
{
for (int i = 0; i < n; i++) 
{
    char examination = Convert.ToChar(new Random().Next(0x041, 0x05A));
    for (int j = 0; j < i; j++)
    {
        if (examination == massiv[j]) {examination = Convert.ToChar(new Random().Next(0x030, 0x039)); j = 0;}
    }
    massiv[i] = examination;
}
}

void FillArray2(char[] massiv2)
{
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n-1; j++)
    {
        char t = massiv2[j];
        massiv2[j] = massiv2[j+1];
        massiv2[j+1] = t;
        count++;
        if(count >= (n*(n-1))) return;
            Console.WriteLine(massiv2);
    }
}
}



FillArray(array);
Console.Write(array);
Console.WriteLine();
FillArray2(array);