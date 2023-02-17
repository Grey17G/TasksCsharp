/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

int getDataUser (string message)
{
    Console.WriteLine (message);
    int result = int.Parse (Console.ReadLine()!);
    return result;
}
int[,] get2DIntArray (int colLenght, int rowLenght, int start, int end)
{
     int [,] array = new int [colLenght,rowLenght];
     for (int i = 0; i< colLenght; i++)
     {
        for (int j = 0; j< rowLenght; j++)
        {
            array[i,j] = new Random(). Next(start, end+1);
        }
     }
     return array;
}
void print2DArray (int [,] array)
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
int FindMinSumString (int [,] array)
{
    int minSum = 0;
    int minSumString =0;
    for (int i=0; i < array.GetLength(0);i++)
    {
        int sum = 0;    
        for (int j = 0; j < array.GetLength(1); j++)
        {                                                                                 
            sum =sum + array [i,j];
            if (sum < minSum || minSum == 0)
            {
                minSum = sum;
                minSumString =i;
            }    
        }    
    }
    return minSumString;
}
int n = getDataUser ("Введите количество cтрок");
int m = getDataUser ("Введите количество столбцов");
int [,] array = get2DIntArray (n,m,0,100);
print2DArray (array);
int MinSumString = FindMinSumString (array);
Console.WriteLine ($"Наименьшая сумма элементов в строке {MinSumString}");

