﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] array2d = new double [3,4];
for (int i=0; i<array2d.GetLength(0); i++)
{
    for(int j=0; j<array2d.GetLength(1); j++)
    {
       array2d [i,j] = new Random(). Next (-100,100) / 10.0;
        Console.Write( array2d[i,j] + " ");
    }
    Console.WriteLine( );
}