// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите m1");
int m1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите n1");
int n1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите m2");
int m2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите n2");
int n2 = int.Parse(Console.ReadLine()!);

int[,] firstArray2D = Create2DArray(m1, n1, -5, 10);
int[,] secondarray2D = Create2DArray(m2, n2, -5, 10);

if (n1 != m2)
{
    Console.WriteLine("Данные матрицы невозможно перемножить. Умножение матриц возможно только при выполнении условия: число столбцов первого множителя равно числу строк второго множителя.");
}

else
{
    Print2DArray(firstArray2D);
    Console.WriteLine();
    Print2DArray(secondarray2D);
    Console.WriteLine();
    Print2DArray(MatrixMultiplication(firstArray2D, secondarray2D));
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] multiplicationResultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < multiplicationResultMatrix.GetLength(0); i++)
    {

        for (int j = 0; j < multiplicationResultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                multiplicationResultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }

    }
    return multiplicationResultMatrix;
}

int[,] Create2DArray(int m, int n, int min, int max)
{

    int[,] matrix = new int[m, n];
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