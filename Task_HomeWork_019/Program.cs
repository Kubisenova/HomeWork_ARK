﻿// №19 Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.   
// 14212 -> нет  23432 -> да  12821 -> да 


// Первое решение

// Console.Clear();

// Console.WriteLine("Введите пятизначное число ");
// string number = Console.ReadLine();
// int polin = number.Length;

// if (polin == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine(" Полиндром ");
//     }
//     else
//     {
//         Console.WriteLine(" Не Полиндром ");
//     }
// }

// else
// {
//     Console.WriteLine(" Ошибка, это не пятизначное число ");
// }






// // Второе решение 
// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }


//  Третье решение
// Напишите программу, которая принимает 
// на вход трёхзначное число и проверяет, 
// является ли оно палиндромом. 

// Console.Clear();

// Console.WriteLine("Введите трёхзначное число ");
// string name = Console.ReadLine();
// int polind = name.Length;

// if (polind == 3)
// {
//     if (name[0] == name[2])
//     {
//         Console.WriteLine(" Полиндром");
//     }
//     else
//     {
//         Console.WriteLine(" Не полиндром");
//     }
// }
// else
// {
//     Console.WriteLine(" Вы ввели не трёхзначное число ");
// }



// Практикуюсь 
// Длина строки - количество элементов (букв):
// string str = "abc"; // три буквы
// Console.WriteLine(str.Length); // 3. Учитываются пробелы и непечатные символы

string str = "З д р а в с т в у й т е !";

for (int i = 0; i < str.Length; i++)
{
    Console.Write(str[i]);
    // Console.WriteLine(str[1]);
    // Console.WriteLine(str[2]);
}




// // char ch = 'a'; // тип данных - символ (буква)
// // Console.WriteLine(str[1]); // 2 - это 3-я буква, 2 - индекс, то есть l
// // Console.WriteLine(str[2]);

// for (int i = 0; i < str.Length; i++)
// {
//     Console.WriteLine(str[i]);
// }








