// Task 13
Console.Clear();


int n = Convert.ToInt32(Console.ReadLine());

if ( n >= -99 && n <= 99 ) Console.Write("третьей цифры нет");
else
if ( n >= -999 && n <= 999 ) Console.Write( n % 10 );
else
if ( n >= -9999 && n <= 9999 ) Console.Write( (n / 10) % 10 );
else
if ( n >= -99999 && n <= 99999 ) Console.Write( (n / 100) % 10 );
else
if ( n >= -999999 && n <= 999999 ) Console.Write( (n / 1000) % 10 );
else
if ( n >= -9999999 && n <= 9999999 ) Console.Write( (n / 10000) % 10 );
else
if ( n >= -99999999 && n <= 99999999 ) Console.Write( (n / 100000) % 10 );
else
if ( n >= -999999999 && n <= 999999999 ) Console.Write( (n / 1000000) % 10 );
else
if ( n >= -2147483647 && n <= 2147483647 ) Console.Write( (n / 10000000) % 10 );



  
