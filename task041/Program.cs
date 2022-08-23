// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 //в условии ошибка

int[] StringToIntArray(string[] array)
{
    int[] intNum = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        intNum[i] = Convert.ToInt32(array[i]);
    }
    return intNum;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
}

int NumPos(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) res += 1;
    }
    return res;
}

Console.Write("Введите подряд несколько положительных или отрицательных целых чисел через запятую. \nКогда закончите ввод, нажмите Enter\n: ");
string rawNumbers = Console.ReadLine(); // сначала записываем то, что ввел пользователь
string[] numbers = rawNumbers.Split(','); // разбиваем строку на массив по разделителю "," и записываем в новый массив

int[] intNumbers = StringToIntArray(numbers); // конвертируем string в int 
Console.WriteLine("Получен массив чисел:");
PrintArray(intNumbers);
int result = NumPos(intNumbers);
Console.WriteLine();
Console.WriteLine($"Количество положительных чисел в массиве = {result}");
