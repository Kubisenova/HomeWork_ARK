// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// // // Первое решение
// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int MakeArray(int a, int b)
// {
//     int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }
//         result = (a / c) % 10;
//     }
//     return result;
// }



// // // // Второе решение
// Console.Clear();
// Console.WriteLine("Введите число:  ");
// string? numA = Console.ReadLine();

// if (numA.Length >= 3)
// {
//     char[] array = numA.ToCharArray();
//     Console.WriteLine(array[2]);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет ");
// }





// // Решение 3

// Console.Clear();

// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));

// // ФУНКЦИИ-------------------------------
// // Функция принимает сообщение для отображения 
// // в консоли, и выводит результат введенных данных пользователем.

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // Функция принимает число введенное пользователем, 
// // количество символов, и выводит третью цифру числа. 
// // Если 3 цифры нет, сообщает и выводит 0.

// int MakeArray(int a, int b)
// {
// int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет, держи: ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }

//         result = (a / c) % 10;
//     }
// return result;
// }



// // Задача 13: Напишите программу, которая выводит третью
// // цифру заданного числа или сообщает, что третьей цифры нет.

// // Решение от преподавателя 
Console.Clear();
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;

}
bool validateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет ");
        return false;
    }
    return true;
}

int number = Prompt("Введите число > ");
if (validateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}

