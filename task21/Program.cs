// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Pifagor3D(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2) //метод нахождения расстояния между 2 точками в 3D пространстве.
{
    return Math.Sqrt((xc2 - xc1) * (xc2 - xc1) + (yc2 - yc1) * (yc2 - yc1) + (zc2 - zc1) * (zc2 - zc1));
}

Console.WriteLine("Введите координаты первой точки ");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки ");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Pifagor3D(x1, y1, z1, x2, y2, z2);
//передаем введенные точки в созданный метод и округляем до 2 знаков как в примерах из условия задачи.
Console.WriteLine($"Расстояние между точками A({x1},{y1},{z1}) и В({x2},{y2},{z2}) = {Math.Round(result, 2)}");