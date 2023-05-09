﻿// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов (от -10 до 10) и выводит их на экран.
// 1, 2, 5, 7, 9 -> [1, 2, 5, 7, 9]
// 6, 1, 3 -> [6, 1, 3]

int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}
// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}