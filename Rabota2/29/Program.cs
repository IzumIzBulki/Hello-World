// task 29

Console.Clear();

int[] massiv = new int[8];
for (int i = 0; i < massiv.Length; i++)
{
    Console.Write($"Введите {i+1} элемент массива: ");
    massiv[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ", massiv)}]");