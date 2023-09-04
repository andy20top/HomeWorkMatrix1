// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

bool IsNumberIndex(int[,] matrix, int i, int j)
{
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
    {
        return true;
    }
    return false;
}

int ElementInMatrix(int[,] matrix, int i, int j)
{
    return matrix[i, j];
}

int rows = SetNumber("Enter number of lines");
int columns = SetNumber("Enter number of columns");
int minValue = SetNumber("Enter min value");
int maxValue = SetNumber("Enter max value");

int[,] matrix = GetMatrix(rows, columns, minValue, maxValue);
ShowMatrix(matrix);
System.Console.WriteLine("_____________________________");

int i = SetNumber("Enter index of lines");
int j = SetNumber("Enter index of columns");
int num = 0;

if (IsNumberIndex(matrix, i, j))
{
    num = ElementInMatrix(matrix, i, j);
    System.Console.WriteLine(num);
}
else System.Console.WriteLine("Такого элемента нет");