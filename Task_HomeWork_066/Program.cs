
// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumFromMToN(m, n);

// вызов функции "сумма чисел от M до N"
void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}









// System.Console.Write("Введите m: ");
// int m = int.Parse(Console.ReadLine());
// System.Console.Write("Введите n: ");
// int n = int.Parse(Console.ReadLine());

// int SumNumbers(int numStart, int numEnd) 
// {
//     if (numStart == numEnd)
//     {
//         return numStart;
//     }
//     else
//     {
//         return numStart + SumNumbers(numStart + 1, numEnd);
//     }
// }

// int sum = SumNumbers(m, n);
// Console.WriteLine($"Сумма чисел от {m} до {n} равна {sum}");
