/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223-> 3 */

Console.Clear();

Console.Write("Введите числа через пробел: ");
int[] numbers = Console.ReadLine().Split().Select(x =>int.Parse(x)).ToArray();
int count = 0;
 
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
        count++;
}
 
Console.WriteLine($"Количество чисел больше 0: {count}");