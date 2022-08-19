// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1] + "]");
}

int[] CreateAndFillArrayRandomInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int SumOfOddIndexElements(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) res += array[i];
    }
    return res;
}

Console.WriteLine("Введите желамое количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateAndFillArrayRandomInt(size, 0, 99);
Console.WriteLine($"Получен массив случайных чисел от 0 до 99, состоящий из {size} элементов:");
PrintArray(arr);
Console.WriteLine();
int result = SumOfOddIndexElements(arr);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {result}");