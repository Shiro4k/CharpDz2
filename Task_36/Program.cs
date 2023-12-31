﻿/*
 Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
        [3, 7, 23, 12] -> 19
        [-4, -6, 89, 6] -> 0
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

int SumShetEl(int[] arr)
{
    int Sum = 0;
    for (int i = 1;i < arr.Length;i +=2)
    {
        Sum += arr[i];
    }
    return Sum;
}

Console.Clear();
int[] arr = FillArray(10, -10, 10);
Console.Write(string.Join(", ", arr));
int sum = SumShetEl(arr);
Console.Write($" ==> {sum}");