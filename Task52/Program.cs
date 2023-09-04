// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }

    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
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

double[] SumInColumns(int[,] matrix)
{
    double[] arraySum = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j,i];
        }
        arraySum[i] = sum;
    }
    return arraySum;
}

void AverageInColumns(double[] array, int numRows)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] / numRows;
        System.Console.WriteLine($"Среднее арифметическое {i+1} столбца - {array[i]}");
    }
}

int rows = SetNumber("Enter number of lines");
int columns = SetNumber("Enter number of columns");
int minValue = SetNumber("Enter min value");
int maxValue = SetNumber("Enter max value");

int[,] matrix = GetMatrix(rows, columns, minValue, maxValue);
ShowMatrix(matrix);
System.Console.WriteLine("________________________");
double[] arraySum = SumInColumns(matrix);
AverageInColumns(arraySum, matrix.GetLength(0));