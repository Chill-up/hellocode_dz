// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

void PrintArrayDouble(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + " | ");
    }
    Console.Write(array[array.Length - 1] + " ]");
}

double[] CreateAndFillArrayRandomDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        // создаем случайное вещественное число в диапазоне от min до max (по-умолчанию это будет от 0 до <1)

        // Чтобы создать случайные числа с плавающей запятой между двумя произвольными значениями, например Next(Int32, Int32) методом для целых чисел, используйте следующую формулу:
        // Random.NextDouble() * (maxValue - minValue) + minValue

        // и округляем его с точностью до 1 знака с помощью Math.Round.
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
    }
    return array;
}

double MaxMinDiff(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return max - min;
}

Console.WriteLine("Введите желамое количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] arr = CreateAndFillArrayRandomDouble(size, 0, 10);
Console.WriteLine($"Получен массив случайных вещественных чисел от 0 до 10, состоящий из {size} элементов:");
PrintArrayDouble(arr);
Console.WriteLine();
double result = MaxMinDiff(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Math.Round(result, 1)}");