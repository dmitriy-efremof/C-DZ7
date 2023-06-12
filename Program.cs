// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите значение m (rows):");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение n (colomns):");
// int n = Convert.ToInt32(Console.ReadLine());

// double [,] array= new double[m,n];

// void Array()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j]= new Random().NextDouble() * (101);
//         }
//     }
// }
// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// Array();
// PrintArray();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите значение (rows):");
// int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;

// Console.WriteLine("Введите значение (colomns):");
// int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

// int m = 5;
// int n = 7;

// int[,] array = new int[m,n];

// void Array()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             array[i,k] = new Random().Next(-100,101);
//         }   
//     }
// }
// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             Console.Write(array[i,k]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// void TetsArray()
// {
//     if (pos1 < 0 || pos1 > array.GetLength(0) - 1 || pos2 < 0 || pos2 > array.GetLength(1) - 1)
//     {
//         Console.WriteLine("Элемент не существует");    
//     }
//     else
//     {
//         Console.WriteLine("Значение элемента массива = {0}", array[pos1, pos2]);
//     }
// }
// Array();
// PrintArray();
// TetsArray();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите значение m (rows):");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение n (colomns):");
// int n = Convert.ToInt32(Console.ReadLine());

// int [,] array= new int[m,n];

// void Array()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j]= new Random().Next(1,10);
//         }
//     }
// }
// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// void SumNumbers()
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i,j];
//         }
//         Console.Write($"{sum / array.GetLength(0)}; ");
//     }
// }
// Array();
// PrintArray();
// Console.WriteLine("________________________");
// Console.Write("Среднее арифметическое элементов в каждом столбце:");
// SumNumbers();