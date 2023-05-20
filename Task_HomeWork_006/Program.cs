// Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
// Console.WriteLine("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// if (numberA %2 == 0)
// {
//   Console.WriteLine("Число чётное ");  
// }
// else
// {
//     Console.WriteLine("Число нечётное "); 
// }

Console.Clear();

Console.WriteLine("Введите число ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);

if (number % 2 == 0)
{
Console.WriteLine("Число чётное ");
}
else
{
    Console.WriteLine("Число НЕ чётное ");
}
