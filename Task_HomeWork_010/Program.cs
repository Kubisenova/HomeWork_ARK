// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Первое решение
// Console.WriteLine(" Введите трехзначное число ");
// int numA = int.Parse(Console.ReadLine()?? "0");
// int numB = (numA/10)%10;
// Console.WriteLine(numB);



// // Второе решение
// // Второе решение - работает.

// Console.WriteLine("Введите трехзначное число: ");
// // число переводим в строку и задаём ей длину

// int size = Convert.ToInt32(Console.ReadLine());

// int number = size.ToString().Length;

// if (number < 3 || number > 3)
// {
// Console.WriteLine("Вы ввели не трехзначное число");
// }
// else
// {
// Console.WriteLine(size);
// int numbC = size;

// numbC = (numbC / 10) % 10;
// Console.WriteLine(numbC);
// }


// // Второе решение
// Console.WriteLine("Введите трехзначное число: ");
// // число переводим в строку и задаём ей длину
// int size = Convert.ToInt32(Console.ReadLine());
// int number = size.ToString().Length;
// if (number < 3 || number > 3)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }
// else
// {
//     Console.WriteLine(size);

//     int numbC = size;

//     numbC = (numbC / 10) % 10;
//     Console.WriteLine(numbC);
// }


// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.



// Решение 1 через рандом 
// Console.Clear();
// int number1 = new Random().Next(100, 1000);
// Console.WriteLine("Трёхзначное число: " + number1);
// int number2 = (number1 / 10) % 10;
// Console.WriteLine("Вторая цифра этого числа " + number2);


// Задача 10: Напишите программу, которая принимает на вход пятизнаяное число 
//  и на выходе показывает вторую и третью цифру этого числа.

// // Решение 2 
// Console.Clear();
// Console.WriteLine("Введите пятизначное число ");
// int size = Convert.ToInt32(Console.ReadLine());
// int number1 = size.ToString().Length;

// if (number1 < 5 || number1 > 5)
// {
//     Console.WriteLine("Вы ввели не пятизначное число");
// }
// else
// {
//       int number2 = size;

//     number2 = (number2 / 100) % 100;
//     Console.WriteLine(number2 + " Здесь показаны вторая и третья цифра пятизначного числа ");
// }




// Решение моё 

Console.Clear();
Console.WriteLine("Введите трёхзначное число ");
int text = Convert.ToInt32(Console.ReadLine());
int number1 = text.ToString().Length;

if (number1 < 3 || number1 > 3)
{
    Console.WriteLine("Вы ввели не трёхзнанчое число");
}
else
{
    int number2 = text;

    number2 = (number2 / 10) % 10;
    Console.WriteLine(number2 + " = вторая цифра трёхзначного числа ");
}