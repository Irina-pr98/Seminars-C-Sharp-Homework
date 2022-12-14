/* Напишите цикл, который принимает на вход два числа (A и B) и  возводит число A в натуральную степень B.
    Нельзя использовать функцию Math.Pow.
    3, 5 -> 243
    2, 4 -> 16 */

Console.Clear();

Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());

int res = a;
for (int i = 1; i < b; i++)
    res = res * a;

Console.WriteLine($"{a} в степени {b}: {res}");