/* Напишите программу, которая заполнит спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07 */

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


Console.Write("Введите размер: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[size, size];
int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    matrix[i, j] = num;
    if (i + j < size - 1 && i <= j + 1)
        j++;
    else if (i + j >= size - 1 && i < j)
        i++;
    else if (i + j > size - 1 && i >= j)
        j--;
    else
        i--;
    num++;
}
PrintMatrix(matrix);