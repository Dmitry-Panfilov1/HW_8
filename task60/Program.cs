// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k");
int k = int.Parse(Console.ReadLine()!);

if (n * m * k > 89)
{
    Console.WriteLine("Данный массив невозможно зполнить неповторяющимися двухзначными числами");
    return;
}
else
{
    int[,,] array3D = Create3DArray(n, m, k, 10, 99);
    Print3DArray(array3D);
}
bool CheckValueForUniq(int[,,] matrix, int value)
{
    bool temp = true;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if(value == matrix[i, j, k]) temp = false;
            }
        }    
    }
    return temp;
}

int[,,] Create3DArray(int n, int m, int w, int min, int max)
{
    int[,,] matrix = new int[m, n, w];
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int tempMatrixValue = 0;
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                while (matrix[i, j, k] == 0)
                {
                    tempMatrixValue = new Random().Next(min, max + 1);
                    if(CheckValueForUniq(matrix, tempMatrixValue)) matrix[i, j, k] = tempMatrixValue;
                }
            }
        }
    }
    return matrix;
}
 
void Print3DArray(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
    }
}
