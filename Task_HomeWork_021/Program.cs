﻿// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



// // Первое решение 

// int x1 = ReadInt("Введите координату X первой точки: ");
// int y1 = ReadInt("Введите координату Y первой точки: ");
// int z1 = ReadInt("Введите координату Z первой точки: ");
// int x2 = ReadInt("Введите координату X второй точки: ");
// int y2 = ReadInt("Введите координату Y второй точки: ");
// int z2 = ReadInt("Введите координату Z второй точки: ");
// int A = x2 - x1;
// int B = y2 - y1;
// int C = z1 - z2;
// double length = Math.Sqrt(A * A + B * B + C * C);
// Console.WriteLine($"Длинна отрезка {length}");
// // Функция ввода сообщения
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }



// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Второе решение 
Console.Clear();

Console.WriteLine("Введите координату точки X1 ");
string textX1 = Console.ReadLine();
int x1 = Convert.ToInt32(textX1);

Console.WriteLine("Введите координату точки X2 ");
string textX2 = Console.ReadLine();
int x2 = Convert.ToInt32(textX2);

Console.WriteLine("Введите координату точки Y1 ");
string textY1 = Console.ReadLine();
int y1 = Convert.ToInt32(textY1);

Console.WriteLine("Введите координату точки Y2 ");
string textY2 = Console.ReadLine();
int y2 = Convert.ToInt32(textY2);

Console.WriteLine("Введите координату точки Z1 ");
string textZ1 = Console.ReadLine();
int z1 = Convert.ToInt32(textZ1);

Console.WriteLine("Введите координату точки Z2 ");
string textZ2 = Console.ReadLine();
int z2 = Convert.ToInt32(textZ2);

int A = x1 - x2;
int B = y1 - y2;
int C = z1 - z2;

int D1 = A * A;
int D2 = B * B;
int D3 = C * C;

int Summa = D1+D2+D3;

double Dlina = Math.Sqrt(Summa);

Console.Write("Расстояние между тремя точками в 3D пространстве = " + Dlina);

