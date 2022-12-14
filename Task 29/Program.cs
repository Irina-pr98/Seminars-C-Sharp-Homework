/* Напишите программу, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы. После записи элементов в массив, необходимо его вывести на экран.
    8
    1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] */


Console.Clear();

Console.Write("Введите количество элементов: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент под индексом {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());;
}

Console.WriteLine($"[{string.Join(", ", array)}]");