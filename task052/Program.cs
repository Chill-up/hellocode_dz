// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintArrayDouble(double[] array)
{
    int arrSize = array.Length;
    Console.Write("[ ");
    for (int i = 0; i < arrSize; i++)
    {
        if (i < arrSize - 1) Console.Write($"{array[i],3} | ");
    }
    Console.Write($"{array[arrSize - 1],3} ]");
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

double[] FindColumnsAverage(int[,] matrix)
{
    int rowSize = matrix.GetLength(0);
    int colSize = matrix.GetLength(1);
    double[] colAverage = new double[colSize]; // результирующий одномерный массив для вещественных чисел.
    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < colSize; j++)
        {
            colAverage[j] = colAverage[j] + matrix[i, j]; // суммируем элементы столбцов, т.е. j
            if (i == rowSize - 1) colAverage[j] = Math.Round((colAverage[j] / rowSize), 1); 
            // когда дошли до последней строки, элементы уже просуммировались и можно найти среднее с точностью до 1 знака.
        }
    }
    return colAverage;
}

int numberRows = new Random().Next(2, 10); // генерируем размер массива
int numberCols = new Random().Next(2, 10);

Console.Clear();

Console.WriteLine($"Сгенерирован следующий массив {numberRows} х {numberCols} : ");
int[,] randomMatrix = CreateMatrixRandomInt(numberRows, numberCols, 0, 10); // генерируем массив с которым будем работать.
PrintMatrixInt(randomMatrix);

double[] result = FindColumnsAverage(randomMatrix);
Console.WriteLine("Среднее арифметическое всех чисел каждого столбца:");
PrintArrayDouble(result);