﻿// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int dayNumber = int.Parse(Console.ReadLine()?? "0");
if (dayNumber > 0 && dayNumber < 6)
{
    Console.WriteLine("Иди, работай пожалуйста  ");
}
else
{
    Console.WriteLine("Можешь отдохнуть  ");
}