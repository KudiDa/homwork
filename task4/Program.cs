﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int max=0;


 Console.Write("введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());

 max = 0;

if (a > max)
    max=a;
if (b>max)
    max=b;
if (c>max)
    max=c;

    Console.WriteLine("max = "+ max);






