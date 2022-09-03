// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiply(int[,] matrixA, int[,] matrixB)
{
    int[,] res = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    int rowLength = matrixA.GetLength(0);
    int colLength = matrixB.GetLength(1);
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            for (int k = 0; k < rowLength; k++)
            {
                res[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return res;
}

int numberRowsA = new Random().Next(2, 2);
int numberRowsB = new Random().Next(2, 2);  // генерируем размер массива
int numberColsA = new Random().Next(2, 2);
int numberColsB = new Random().Next(2, 2);

while (numberColsA != numberRowsB) // генерируем всегда валидные для умножения матрицы
{
    numberColsA = new Random().Next(2, 2);
    numberRowsB = new Random().Next(2, 2);
}

int[,] matrixA = CreateMatrixRandomInt(numberRowsA, numberColsA, 0, 10); // генерируем матрицы с которыми будем работать.
int[,] matrixB = CreateMatrixRandomInt(numberRowsB, numberColsB, 0, 10);

// Матрицы из условия задачи
// int[,] matrixA = new int[,] { { 2, 4 }, { 3, 2 } };
// int[,] matrixB = new int[,] { { 3, 4 }, { 3, 3 } };

Console.Clear();

Console.WriteLine($"Сгенерированы две матрицы ");
Console.WriteLine($"Матрица А {numberRowsA} х {numberColsA} : ");
Console.WriteLine($"Матрица B {numberRowsB} х {numberColsB} : ");
PrintMatrixInt(matrixA);
Console.WriteLine();
PrintMatrixInt(matrixB);

int[,] resMatrix = MatrixMultiply(matrixA, matrixB);

Console.WriteLine();
Console.WriteLine("Результат умножения матрицы А на матрицу B:");
PrintMatrixInt(resMatrix);