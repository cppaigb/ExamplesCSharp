﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 18;
int c1 = 9880;
int a2 = 444;
int b2 = 88;
int c2 = 9;
int a3 = 19;
int b3 = 68;
int c3 = 559;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

//2 способоб записи (функциональное программирование)

int max = Max(Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

// Console.WriteLine(max1);
// Console.WriteLine(max2);
// Console.WriteLine(max3);

Console.Write("Максимальное значение: ");
Console.WriteLine(max);
