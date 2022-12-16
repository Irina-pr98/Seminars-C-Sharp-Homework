/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    [3 7 22 2 78] -> 76 */

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToDouble(new Random().Next(10,1000)) / 100;
}

void ReleaseArray(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }
    Console.WriteLine($"Максимальное число: {max}, минимальное число: {min}");
    Console.WriteLine($"Разница между максимальным и минимальным числом: {max - min}");
}

Console.Clear();

Console.Write("Введите размер массива:  ");
int len = Convert.ToInt32(Console.ReadLine());
double[] array = new double[len];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", " , array)}]");
ReleaseArray(array);