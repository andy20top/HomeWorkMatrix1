// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetDoubleMatrix(int rows, int columns, int minValue, int maxValue)
{
    double[,] matrix = new double[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = Math.Round(rand.Next(minValue, maxValue+1) + rand.NextDouble(), 1);
        }
    }

    return matrix;
}

void ShowDoubleMatrix (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int SetNumber(string msg)
{
    Console.WriteLine(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int rows = SetNumber("Enter number of lines");
int columns = SetNumber("Enter number of columns");
int minValue = SetNumber("Enter min value");
int maxValue = SetNumber("Enter max value");

double[,] matrix = GetDoubleMatrix(rows, columns, minValue, maxValue);
ShowDoubleMatrix(matrix);