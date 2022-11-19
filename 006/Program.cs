int a = 1;
int d = 2;
int f = 6;
int g = 8;
int h = 4;

int max = a;

if (a > max) max = a;
if (d > max) max = d;
if (f > max) max = f;
if (g > max) max = g;
if (h > max) max = h;

Console.Write("max = ");
Console.Write(max);