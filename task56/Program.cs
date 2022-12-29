// Задайте прямоугольный двумерный массив, напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите размер стороны прямоугольного массива");
int m = int.Parse(Console.ReadLine()!);

 
int[,] array2D = Create2DArray(m, -5, 10);
Print2DArray(array2D);
MinSumRow(array2D);


void MinSumRow(int[,] matrix)
{
    int sumMin = 0;
    //int sumMin = 10 * matrix.GetLength(1); // sumMin должен изначально равняться максимально возможной сумме элементов строки, либо сумме любой строки.
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sumMin += matrix[0, j];
    }
    int sumMinRowIndex = 0;
    
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        int tempRowIndex = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
            tempRowIndex = i;
        }
        if (sumRow < sumMin) 
        {
            sumMin = sumRow;
            sumMinRowIndex = tempRowIndex + 1;
        }
    }
    Console.WriteLine($"минимальная сумма элементов у {sumMinRowIndex} строки");
}
 
 
int[,] Create2DArray(int m, int min, int max)
{
    int[,] matrix = new int[m, m];
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
 
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
