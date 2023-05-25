﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



// // Первое решение 

// int number = ReadInt("Введите число N: ");

// for (int i = 1; i <= number; i++)
// { 
//     Console.Write($"{i*i*i} ");
// }
// // Функция ввода сообщения
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }




// Второе решение 

Console.Write("Введите число N: ");
string text_N = Console.ReadLine();
double N = Convert.ToInt32(text_N);
double x = 0;
double y = 0;
while (x <= N)
{
    y = Math.Pow(x, 3);
    Console.Write("   " + y );
    x++;
}