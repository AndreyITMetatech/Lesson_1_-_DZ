// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int max = 0;
Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
max = a;

Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("c = ");
int c = Convert.ToInt32(Console.ReadLine());

if (b > a && b > c) max = b;
if (c > a && c > b) max = c;

Console.WriteLine($"{a} , {b} , {c} max = {max}");