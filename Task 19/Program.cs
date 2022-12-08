/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
    14212 -> нет
    12821 -> да
    23432 -> да */

Console.Clear();

Console.Write("Введите пятизначное число: ");
string? n = Console.ReadLine();
int length = n.Length;

if (length == 5)
{
    if (n[0] == n[4] && n[1] == n[3])
        Console.WriteLine($"{n} - палиндром");
    else
        Console.WriteLine($"{n} - не палиндром");
}
else
    Console.WriteLine($"{n} не пятизначное число");