// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(number, count);


void NaturalToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + " ");
    }
}




// Console.Write("Введите N: ");
// int n = 3;// int.Parse(Console.ReadLine());

// Console.WriteLine(PrintNumbers(1, n));

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }

// // Что происходит в PrintNumbers:
// // 1. 
//     // start == 1, end == 3
//     // в if не заходим
//     // в return "1 " + результат функции PrintNumbers(2, 3)
//     // "1 " + "2 3"
//     // "1 2 3"

// // 2.
//     // start == 2, end == 3
//     // в if не заходим
//     // в return "2 " + результат функции PrintNumbers(3, 3)
//     // "2 " + "3" == "2 3"

// // 3. 
//     // start == 3, end == 3
//     // в if заходим и возвращаем "3"

