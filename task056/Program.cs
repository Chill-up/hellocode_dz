// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int MinSumNumbersRowInMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int[] sumRows = new int[rows]; // массив для складывания результатов суммирования строк.
    int minIndex = 0;
    for (int i = 0; i < rows; i++)
    {
        int sum = matrix[i, 0];
        for (int j = 1; j < cols; j++)
        {
            sum += matrix[i, j];
            sumRows[i] = sum; //записываем результат сложения элементов строк в том же порядке (по i).
        }
    }
    int min = sumRows[0];
    // задаем первый элемент массива сумм как минимальный, и сравниваем с ним остальные элементы.
    for (int k = 0; k < sumRows.Length; k++)
    {
        if (sumRows[k] < min)
        {
            min = sumRows[k];
            minIndex = k; //записываем и возвращаем индекс минимального элемента.
        }
    }
    return minIndex;
}
Console.Clear();

Console.WriteLine($"Сгенерирован следующий массив : \n");

int[,] randomMatrix = CreateMatrixRandomInt(4, 2, 0, 10); // генерируем массив с которым будем работать.

PrintMatrixInt(randomMatrix);

Console.WriteLine();

int result = MinSumNumbersRowInMatrix(randomMatrix);

Console.WriteLine($"Минимальная сумма элементов в строке {result + 1}\n");


