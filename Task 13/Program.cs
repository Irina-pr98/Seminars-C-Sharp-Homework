/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
    (без использования нуиерации строк)
    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6 */

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; n > 1000; i++)
{
    n /= 10;       
}

if (n > 100 && n < 1000)
{
    int m = n % 10;
    Console.WriteLine($"Третья цифра числа: {m}");
}
else
    Console.WriteLine("Третьей цифры нет");