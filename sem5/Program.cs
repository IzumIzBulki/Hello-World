// // task 19

// Console.Clear();
// Console.Write("Введите число: ");
// string? n = Console.ReadLine();
// int newNumber = 0;
// for (int i = n.Length - 1; i >= 0; i--)
// {
//     newNumber = newNumber + Convert.ToInt32(int.Parse(n[i].ToString()) * Math.Pow(10, i)); // начинаем с последнего символа получаем его версию типо "если 5 то 50000 + 4(4000) + 3(300) + 2(20) + 1 = 54321 и если исток был 12345 тогда полиндром
// }
// Console.WriteLine(newNumber);
// if (newNumber == int.Parse(n))
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// // task 31


// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 124); // [-9, 9]
// }


// void ReleaseArray(int[] array)
// {
//     int sum = 0;
//         for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <=99)                                // заменив все условие на array[i] = array[i] * -1; каждый элемент массива замениться на массив с противоположным знаком
//             sum += 1;                                                       // или так записать  array[i] *= (-1);
//     }
//     Console.WriteLine($"Сумма {sum}");
   
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива(или 123): ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// ReleaseArray(array);




// // task 33


// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9, 9]
// }


// string ReleaseArray(int[] array, int k)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == k)
//             return "yes";
//     }
//     return "no";
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.Write("Введите число, которое нужно найти в массиве: ");
// int k = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ReleaseArray(array, k));



// task 35


// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 124); 
// }


// void ReleaseArray(int[] array)
// {
//     int sum = 0;
//         for (int i = 0; i < array.Length-1; i++)
//     {
//         if (array[i] >= 10 && array[i] <=99) sum++;                                
//     }
//     Console.WriteLine($"Сумма {sum}");
   
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива(или 123): ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// ReleaseArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");


// task 37v1


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11); // [1, 10]
}


void ReleaseArray(int[] array)
{
    int[] resultArray = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        resultArray[i] = array[i] * array[array.Length - i - 1];
    Console.WriteLine($"[{string.Join(", ", resultArray)}]");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);


// task 37v2


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11); // [1, 10]
}


void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        Console.Write($"{array[i] * array[array.Length - i - 1]} ");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
