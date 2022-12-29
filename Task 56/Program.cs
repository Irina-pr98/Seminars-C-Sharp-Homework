/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
    суммой элементов.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
    1 строка */

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


int ReleaseMatrix(int[,] matrix)
{
    int minRow = 0;
    int minSumRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
        minRow += matrix[0, i];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) 
            sumRow += matrix[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов: {minSumRow + 1}");
    return minRow;
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0] == size[1])
{
    Console.Write("Вы ошиблись!\nВведите размер прямоугольной матрицы: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный массив: ");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов равна: {ReleaseMatrix(matrix)}");