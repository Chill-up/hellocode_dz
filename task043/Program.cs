// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

void PrintArrayDouble(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + " | ");
    }
    Console.Write(array[array.Length - 1] + " ]");
}

double[] FindCross(double a, double b, double c, double d)
{
    double[] res = new double[2];
    double x = ((c - a) / (b - d));
    double y = b * x + a;
    res[0] = Math.Round(x, 1);
    res[1] = Math.Round(y, 1);
    return res;
}
double[] crossCoordinats = FindCross(b1, k1, b2, k2);

PrintArrayDouble(crossCoordinats);
