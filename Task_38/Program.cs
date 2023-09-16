/*
 Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
 */

double[] FillArray(int size, int min = 0, int max = 1)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min, max + 1) + rand.NextDouble(); 
    }

    return arr;
}

double MaxMas(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double MinMas(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

Console.Clear();
double[] arr = FillArray(4, 1, 10);
Console.WriteLine(String.Join(", ", arr));
double max = MaxMas(arr);
Console.WriteLine($"Max - {max}");
double min = MinMas(arr);
Console.WriteLine($"Min - {min}");
double dif = max - min;
Console.WriteLine($"Difference - {dif}");
