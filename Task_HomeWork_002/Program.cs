﻿// Задача 2: Напишите программу, которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число; ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число; ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// if(numberA > numberB)
// {
//     Console.WriteLine("Первое число больше второго");
// }
// else
// {
//     Console.WriteLine("Второе число больше первого");
// }

Console.WriteLine("Введите первое число ");
string text1 = Console.ReadLine();
int numberA = Convert.ToInt32(text1);

Console.WriteLine("Введите второе число ");
string text2 = Console.ReadLine();
int numberB = Convert.ToInt32(text2);

if (numberA > numberB)
{
    Console.WriteLine("Первое число " + numberA + " больше второго числа " + numberB);
}
if (numberA < numberB)
{
    Console.WriteLine("Второе число " + numberB + " больше первого числа " + numberA);
}


