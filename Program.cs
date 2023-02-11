// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Enter quantity Rows --> ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantity Columns --> ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = new int[x, y];
int[] MaxRows = new int[x];

for (int i = 0; i < Matrix.GetLength(0); i++)
{
    int MaxSumValRows = 0;
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
        Matrix[i, j] = new Random().Next(0, 10);
        Console.Write($"{Matrix[i, j]} ");
        MaxSumValRows = MaxSumValRows + Matrix[i, j];
        MaxRows[i] = MaxSumValRows;
    }
    Console.WriteLine();
}

Console.WriteLine();

void SRCMaxValRows(int[] MaxRows)
{
    int Row = 0;
    for (int i = 0; i < MaxRows.GetLength(0); i++)
    {
        Console.Write($"{MaxRows[i]} ");
    }
    Console.WriteLine();
    int count = 1;
    while (Row != MaxRows.GetLength(0) - 1)
    {
        if (MaxRows[Row] > MaxRows[Row + 1])
        {
            int max = MaxRows[Row];
            MaxRows[Row] = MaxRows[Row + 1];
            MaxRows[Row + 1] = max;
            ++count;
        }
        ++Row;
    }
    Console.WriteLine($"Smallest sum of elements: {count} row");
}

SRCMaxValRows(MaxRows);
