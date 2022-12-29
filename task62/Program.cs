// Напишите программу, которая заполнит спирально массив 4 на 4. 

int sideLength = 4;
int[,] array2D = CreateSpiralSquare2DArray(sideLength);

Print2DArray(array2D);

int[,] CreateSpiralSquare2DArray(int m)
{
    int[,] matrix = new int[m, m];
    int count = 1;
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[0, j] = count;
        count++;
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        matrix[i, matrix.GetLength(0) - 1] = count;
        count++;
    }
    for (int j = matrix.GetLength(1) - 2; j >= 0 ; j--)
    {
        matrix[matrix.GetLength(0) - 1, j] = count;
        count++;
    }
    for (int i = matrix.GetLength(0) - 2; i > 0; i--)
    {
        matrix[i, 0] = count;   
        count++;
    }
    
    int rowPosition = 1;
    int coloumnPosition = 1;

    while (count < matrix.GetLength(0) * matrix.GetLength(1) && CheckArray2DFilling(matrix))
    {
        while (matrix[rowPosition, coloumnPosition + 1] == 0)
        {
            matrix[rowPosition, coloumnPosition] = count;
            count++;
            coloumnPosition++;
        }
        while (matrix[rowPosition + 1, coloumnPosition] == 0)
        {
            matrix[rowPosition, coloumnPosition] = count;
            count++;
            rowPosition++;
        }
        while (matrix[rowPosition, coloumnPosition - 1] == 0)
        {
            matrix[rowPosition, coloumnPosition] = count;
            count++;
            coloumnPosition--;
        }
        while (matrix[rowPosition - 1, coloumnPosition] == 0)
        {  
            matrix[rowPosition, coloumnPosition] = count;
            count++;
            rowPosition--;
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    matrix[i, j] = count;
                    count++;
                }
            }
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

bool CheckArray2DFilling(int[,] matrix)
{
    bool matrixNotFilled = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == 0) matrixNotFilled = true;
        }
    }
    return matrixNotFilled;
}