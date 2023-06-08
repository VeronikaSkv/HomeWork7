// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
//  элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int sum0= 0;
double Sum=0;
int [,] array2d = new int [3,4];
for (int i=0; i<array2d.GetLength(0); i++)
{
    for(int j=0; j<array2d.GetLength(1); j++)
    {
       array2d [i,j] = new Random(). Next (1,10);
        Console.Write( array2d[i,j] + " ");
           }
    Console.WriteLine( );
}

Console.Write($"Среднее арифметическое каждого столбца: ");

for (int j=0; j<array2d.GetLength(1); j++)
{
    for(int i=0; i<array2d.GetLength(0); i++)
    {
       sum0 = sum0+ array2d [i,j];
           }
           Sum=sum0*10/3 /10.0;
           sum0=0;
    Console.Write($"{Sum}; ");
}