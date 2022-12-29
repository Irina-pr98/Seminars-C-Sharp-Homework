/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18 */

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

int[,] ReleaseMatrix(int[,] FirstMatrix, int[,] SecondMatrix)
{
    int[,] result = new int[FirstMatrix.GetLength(0), FirstMatrix.GetLength(1)];
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
            result[i, j] = FirstMatrix[i, j] * SecondMatrix[i, j];
    }
    return result;
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] FirstMatrix = new int[size[0], size[1]];
int[,] SecondMatrix = new int[size[0], size[1]];
InputMatrix(FirstMatrix);
InputMatrix(SecondMatrix);
Console.WriteLine("Первый начальный массив: ");
PrintMatrix(FirstMatrix);
Console.WriteLine("Второй начальный массив: ");
PrintMatrix(SecondMatrix);
Console.WriteLine("Конечный массив:");
PrintMatrix(ReleaseMatrix(FirstMatrix, SecondMatrix));