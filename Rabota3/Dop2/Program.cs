//Dop 2

Console.Clear();
Console.Write("Введите количество месяцев, где Вася получал оценки: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] month = new int[n];
int SummThree = 0;int SummFour = 0;
for (int i = 0; i < n; i++)
{
    month[i] = new Random().Next(1, 32);
    if (month[i] % 2 == 0)SummThree ++;
    else SummFour ++;
}
Console.WriteLine($"Даты месяцев, где Вася получал оценки: [{String.Join(" ", month)}]");
Console.Write("Дни где Вася получил тройку: ");
for (int i = 0; i < n; i++)
    if (month[i] % 2 == 0) Console.Write($"{month[i]} ");
Console.WriteLine();
Console.Write("Дни где Вася получил четверку: ");
for (int i = 0; i < n; i++)
    if (month[i] % 2 != 0) Console.Write($"{month[i]} ");
Console.WriteLine();
if (SummFour > SummThree) Console.WriteLine("Может расчитывать на положительную оценку");
else Console.WriteLine("Не может расчитывать на положительную оценку");







 

