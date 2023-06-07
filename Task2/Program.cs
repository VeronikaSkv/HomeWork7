// Задача 50. Напишите программу, которая на вход принимает значение 
// элемента в двумерном массиве, и возвращает позицию этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите число для проверки наличия такого элемента в массиве");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int [,] array2d = new int [3,4];
for (int i=0; i<array2d.GetLength(0); i++)
{
    for(int j=0; j<array2d.GetLength(1); j++)
    {
       array2d [i,j] = new Random(). Next (1,15);       
        Console.Write( array2d[i,j] + " ");
    }
    Console.WriteLine( );
}
for (int i=0; i<array2d.GetLength(0); i++)
{
    for(int j=0; j<array2d.GetLength(1); j++)
    {
      if( array2d [i,j] == number) 
      {
        Console.WriteLine ($"Элемент равный {number} расположен в массиве с индексами {i},{j}");
        sum++;}
          
       
    }
   
}
if (sum == 0 ) Console.WriteLine ($"числа {number} нет в массиве");