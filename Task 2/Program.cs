/* Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
    a = 5; b = 7 -> max = 7
    a = 2; b = 10 -> max = 10
    a = -9; b = -3 -> max = -3 */

Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n > m)
    Console.WriteLine("Первое число " + n + " больше, чем второе " + m);
else if (n < m)
    Console.WriteLine("Второе число " + m + " больше, чем первое " + n);
else
    Console.WriteLine("Числа равны");