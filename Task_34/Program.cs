/*
 Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
                            [345, 897, 568, 234] -> 2
 */

int[] FillArray(int size, int min = 0, int max = 1)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {

        arr[i] = rand.Next(min, max + 1);
    }

    return arr;
}

int Shet(int[] arr)
{
    int shet = 0;
    for (int i = 0;i < arr.Length;i++) 
    {
        if (arr[i] % 2 == 0)
        {
            shet++;
        }
    }
    return shet;
}

int[] arr = FillArray(4, 100, 999);
Console.Write(String.Join(", ", arr));
int quantiti = Shet(arr);
Console.Write($" ==> {quantiti}");