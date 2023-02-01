﻿/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int GetDataFromUser (string message)
{
    Console.WriteLine (message);
    int result = int.Parse (Console.ReadLine()!);
    return result;
}

double [ , ] get2DDoubleArray (int colLenght, int rowLenght, int start, int end)
{
    double[,] array = new double [colLenght, rowLenght];
    for (int i =0; i< colLenght; i++)
    {
        for (int j =0; j < rowLenght; j++)
        { 
            array[i,j] = new Random(). Next(start, end+1) + Math.Round(new Random().NextDouble(),2);
        }
    }
    return array;
}

void print2DArray (double [,] array)
{
    for (int i=0;i < array.GetLength(0);i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int n = GetDataFromUser ("Введите количество строк");
int m = GetDataFromUser ("Введите количество столбцов");
double [,] array = get2DDoubleArray (n,m,-100,100);
print2DArray (array);


