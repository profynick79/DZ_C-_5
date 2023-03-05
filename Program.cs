// Задача 34: Задайте массив, заполненный случайными 
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

// Console.Write("Введите число элементов массива: ");
// int size = int.Parse(Console.ReadLine());

// Console.Write("Введите число, обозначающее нижнюю границу массива: ");
// int minN = int.Parse(Console.ReadLine());

// Console.Write("Введите число, обозначающее верхнюю границу массива: ");
// int maxN = int.Parse(Console.ReadLine());

// int[] array = GetArray(size, minN, maxN);
// int oddSum = 0;

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
//     if (i % 2 == 1)
//     {
//         oddSum = oddSum + array[i];
//     }
// }
// Console.WriteLine($"В массиве: [{String.Join("; ", array)}] \n сумма элементов, стоящих на нечётных позициях : {oddSum}.");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите число элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
double[] FillArray()
{
    int size = array.Length;
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return result;
}
int i = 0;
double max = array[0];
double min = array[0];

for (i = 0; i < size; i++)

    if (array[i] > max)
    {
        max = array[i];
    }
else if (array[i] < min)
    {
        min = array[i];
    }

double diff = max - min;

Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным \n элементом массива: {diff}");
