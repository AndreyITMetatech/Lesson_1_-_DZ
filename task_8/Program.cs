﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
 
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
while (N > 1)
{
if (N % 2 == 0) 
Console.WriteLine(N + " ");
N = N - 1;
}