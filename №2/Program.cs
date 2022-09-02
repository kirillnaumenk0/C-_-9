/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */

int WriteNum(int m, int n, int sum = 0)
{
    sum += m;
    if (m == n) return sum;
    return WriteNum(m + 1, n, sum);
}

Console.WriteLine("Введите число №1: ");
int m= int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №2: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(WriteNum(m, n));
