// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

// Внимание! Пользователь начинает считать и вводить на поиск элементы не с 0, а с 1. 

void PrintMatrixInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
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

int FindElementInMatrix(int[,] matrix, int rowFind, int colFind)
{

    if (rowFind <= matrix.GetLength(0) && colFind <= matrix.GetLength(1)) return matrix[rowFind - 1, colFind - 1];
    // Если заданный для поиска адрес находится в пределах матрицы, то возвращаем значение, находящееся по этому адресу -1
    // -1 потому что нумерация элементов в массиве с нуля, а у пользователя с 1.  
    else return -404; // если значение за пределами массива, то возвращаем значение, которого в массиве быть не может.
}

Console.WriteLine("Введите строку искомого элемента: ");
int findRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец искомого элемента: ");
int findCol = Convert.ToInt32(Console.ReadLine());

int numberRows = new Random().Next(2, 10); // если будет одна строка, то это уже будет выглядеть как не двумерный массив
int numberCols = new Random().Next(1, 10);

Console.WriteLine("Сгенерирован следующий массив: ");
int[,] randomMatrix = CreateMatrixRandomInt(numberRows, numberCols, 0, 99);
PrintMatrixInt(randomMatrix);

int result = FindElementInMatrix(randomMatrix, findRow, findCol);

if (result != -404) Console.WriteLine($"Элемент по адресу строка {findRow}, столбец {findCol} = {result}");
else Console.WriteLine($"Элемент по адресу строка {findRow}, столбец {findCol} отсутствует в массиве");

