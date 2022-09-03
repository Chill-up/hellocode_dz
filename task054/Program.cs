// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintMatrixInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" ]");
    }
}

int[,] CreateMatrixRandomInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void SortMatrixRowNumbersMaxToMin(int[,] matrix)
{
    int rowLength = matrix.GetLength(0);
    int colLength = matrix.GetLength(1);
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength - 1; j++)
        {
            int maxIndex = j; // индекс максимального элемента в строке
            for (int k = j + 1; k < colLength; k++)  //j+1 чтобы не перебирать уже отсортированные элементы 
            {
                if (matrix[i, k] > matrix[i, maxIndex]) maxIndex = k;
            }
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, maxIndex];
            matrix[i, maxIndex] = temp;
        }
    }
}

Console.Clear();

int numberRows = new Random().Next(2, 6); // генерируем размер массива
int numberCols = new Random().Next(2, 12);

int[,] randomMatrix = CreateMatrixRandomInt(numberRows, numberCols, 0, 100); // генерируем массив с которым будем работать.

Console.WriteLine($"Сгенерирован следующий массив {numberRows} х {numberCols} : ");

PrintMatrixInt(randomMatrix);

SortMatrixRowNumbersMaxToMin(randomMatrix);

Console.WriteLine();

PrintMatrixInt(randomMatrix);