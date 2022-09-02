/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 */

Console.WriteLine("Введите число №1: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №2: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int result = Akk(m, n);
Console.Write($"Функция Аккермана = {result} ");

int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akk(m - 1, 1);
    else return Akk(m - 1, Akk(m, n - 1));
}