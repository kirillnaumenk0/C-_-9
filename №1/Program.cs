/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
 */


int WriteNum(int m, int n)
{
    Console.Write(m + " ");
    if(m == n) return n;
    return WriteNum(m + 1, n);
}

Console.WriteLine("Введите число №1: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №2: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
WriteNum(m, n);