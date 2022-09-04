// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintMatrixInt3D(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++) // индексы в таком порядке чтобы получить вывод как в примере для задания. 
    // если в примере ошибка и нужно получить именно построчно, то индексы будут перебираться в обычном порядке.
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                Console.Write($"{matrix[i, j, k],5}({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}

bool CheckDouble(int number, int[,,] array3d) //метод для поиска сгенерированных повторов.
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                if (array3d[i, j, k] == number) return true;
            }
        }
    }
    return false;
}

int[,,] CreateMatrixRandomInt3D(int row, int col, int z, int min, int max)
{
    int[,,] matrix = new int[row, col, z];
    int temp = 0;
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < z; k++)
            {
                temp = rnd.Next(min, max + 1);
                while (CheckDouble(temp, matrix) == true)
                {
                    temp = rnd.Next(min, max + 1);
                }
                matrix[i, j, k] = temp;
            }
        }
    }
    return matrix;
}

int[,,] matrix3d = CreateMatrixRandomInt3D(2, 2, 2, 10, 99);

PrintMatrixInt3D(matrix3d);