/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
    нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0 */

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11);
}

void ReleaseArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum += array[i];
    }
    Console.WriteLine($"Сумма нечетных элементов равна: {sum}");
}

Console.Clear();

Console.Write("Введите размер массива:  ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", " , array)}]");
ReleaseArray(array);