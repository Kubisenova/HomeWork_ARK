// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Решение первое 

// int numberA = ReadInt("Введите число: ");
// int numberB = ReadInt("Введите степень: ");
// ToDegree(numberA, numberB);

// // Функция возведения в степень
// void ToDegree(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine(a + " в степени " + b + " = " + result);
// }

// // Функция ввода
// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Решение 2

Console.Clear();

Console.WriteLine("Введите число ");
string textA = Console.ReadLine();
int A = Convert.ToInt32(textA);

Console.WriteLine("Введите степень в которую хотите возвести число ");
string textB = Console.ReadLine();
int B = Convert.ToInt32(textB);

double x = Math.Pow(A, B);
Console.WriteLine("Число " + A + " возведённое в степень " + B + " равно = " + x);