﻿// Задача 34: Задайте массив, заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.Write("Введите число элементов массива: ");
// int size = int.Parse(Console.ReadLine());
// int[] array = GetArray(size, 100, 999);
// int count = 0;

// //Метод генерации массива
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size]; 
//     for (int i = 0; i < result.Length; i++) // result.Length = size
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }

// for (int i = 0; i < size; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         count += 1;
//     }
// }
// Console.WriteLine($"В массиве: [{String.Join("; ", array)}] количество четных чисел: {count}.");




// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите число элементов массива: ");
int size = int.Parse(Console.ReadLine());

Console.Write("Введите число, обозначающее нижнюю границу массива: ");
int minN = int.Parse(Console.ReadLine());

Console.Write("Введите число, обозначающее верхнюю границу массива: ");
int maxN = int.Parse(Console.ReadLine());

int[] array = GetArray(size, minN, maxN);
int oddSum = 0;

//Метод генерации массива
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size]; 
    for (int i = 0; i < result.Length; i++) // result.Length = size
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

for (int i = 0; i < size; i++)
{
    if (i % 2 == 1)
    {
        oddSum = oddSum + array[i];
    }
}
Console.WriteLine($"В массиве: [{String.Join("; ", array)}] \n сумма элементов, стоящих на нечётных позициях : {oddSum}.");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76


