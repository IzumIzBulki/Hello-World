Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}


int c1 = 1;
int c2 = 2;
int c3 = 3;
int c4 = 14;
int c5 = 5;
int c6 = 6;
int c7 = 7;
int c8 = 8;
int c9 = 90;

// int max1 = Max(c1, c5, c9);
// int max2 = Max(c2, c6, c8);
//int max3 = Max(c3, c7, c4);
//int max = Max(max1, max2, max3);

int max = Max(Max(c1, c5, c9), Max(c2, c6, c8), Max(c3, c7, c4));

Console.WriteLine(max);

