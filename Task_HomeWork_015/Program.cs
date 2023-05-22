// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число от 1 до 7: ");
// int dayNumber = int.Parse(Console.ReadLine()?? "0");
// if (dayNumber > 0 && dayNumber < 6)
// {
//     Console.WriteLine("Иди, работай пожалуйста  ");
// }
// else
// {
//     Console.WriteLine("Можешь отдохнуть  ");
// }

// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

// Console.Clear();

// Console.Write("Введите число ");
// int numberDay = Convert.ToInt32(Console.ReadLine());

// if (numberDay > 5)
// {
//     Console.Write("Иди отдыхай");
// }
// else
// {
//     Console.Write("Иди работай");
// }


// Второе решение 
Console.Clear();

Console.Write("Введите число дня недели ");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay == 1)
{
    Console.Write("Иди работай, понедельник");
}
if (numberDay == 2)
{
    Console.Write("Иди работай, вторник");
}
if (numberDay == 3)
{
    Console.Write("Иди работай, среда");
}
if (numberDay == 4)
{
    Console.Write("Иди работай, четверг");
}
if (numberDay == 5)
{
    Console.Write("Иди работай, пятница");
}
if (numberDay == 6)
{
    Console.Write("Иди отдыхай, суббота");
}
if (numberDay == 7)
{
    Console.Write("Иди отдыхай, воскресенье");
}
if (numberDay >=8)
{
    Console.Write("Такого дня недели нет ");
}