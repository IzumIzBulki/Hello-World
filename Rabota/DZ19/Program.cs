// Task 19 v.1

Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());

if (n<9999) Console.Write("Введите 5 значное число");
else
if (n>99999) Console.Write("Введите 5 значное число");
else
if ((n / 10000) % 10 == n  % 10 && (n / 1000) % 10 == (n/10)  % 10) Console.Write("palindrome");
else
    Console.Write("NotPalindrome");


// Task 19 v.2

int n1 = 0; int n2 = n%10; int n11 = 0; int n22 = 0;
if (n<9999) Console.Write("Введите 5 значное число");
else
if (n>99999) Console.Write("Введите 5 значное число");
else
{
while (n>9999)
    n = n/10;
    n1 = n;
while (n>99)
    n /=10;
    n11 = n;
while (n>9)
    n /=10;
    n22 = n;
if (n1%10 == n11%10 && n22%10 == n2) Console.Write("palindrome");
else
    Console.Write("NotPalindrome");
}

