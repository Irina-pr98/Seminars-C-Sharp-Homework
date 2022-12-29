/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке 
    от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30 */

int rec(int m, int n)
{
    if (m == 0)
        return (n * (n + 1)) / 2;
    if (n == 0)
        return (m * (m + 1)) / 2;
    if (m == n)
        return m;
    if (m < n)
        return n + (rec(m, n - 1));
    return n + (rec(m, n - 1));   
}

Console.Clear();

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));