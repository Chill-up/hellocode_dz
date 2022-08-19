// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int NumberOfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

Console.WriteLine("Введите желамое количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateAndFillArrayRandomInt(size, 100, 999);
Console.WriteLine("Получен массив случайных чисел от 100 до 999:");
PrintArray(arr);
Console.WriteLine();
int result = NumberOfEven(arr);
Console.WriteLine($"Количество чётных чисел в массиве -> {result}");