﻿// Задача 8: Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число: ");
// int numberN = Convert.ToInt32(Console.ReadLine());
// for(int i=2; i<=numberN; i=i+2)
// {
//     Console.WriteLine(i + " - это чётное число");
// }

Console.Clear();

Console.WriteLine("Введите число: ");
string text = Console.ReadLine();
int numberN = Convert.ToInt32(text);


for (int i = 2; i < numberN; i = i + 2)
{
    Console.WriteLine(i + " - это чётное число");
}