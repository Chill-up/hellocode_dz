// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("]");
    }
}

double[,] CreateMatrixRandomDouble(int row, int col)
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * 10), 1);
        }
    }
    return matrix;
}
Console.Clear();
Console.WriteLine("Введите желаемое кол-во строк (число):");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите желаемое кол-во столбцов (число):");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[,] res = CreateMatrixRandomDouble(rows, cols);
Console.WriteLine($"Сгенерирован массив {rows} x {cols} :\n");
PrintMatrixDouble(res);