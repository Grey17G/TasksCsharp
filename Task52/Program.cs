/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetDataFromUser (string message)
{
    Console.WriteLine (message);
    int result = int.Parse (Console.ReadLine()!);
    return result;
}

int[,] get2DDoubleArray (int colLenght, int rowLenght, int start, int end)
{
     int [,] array = new int [colLenght,rowLenght];
     for (int i = 0; i< colLenght; i++)
     {
        for (int j = 0; j< rowLenght; i++)
        {
            array[i,j] = i =j;
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

int getAverageSum (int [,] array, int colLenght, int rowLenght)
{                        
    int sum = 0;
    int a =0;
    for (int i=0;i<colLenght;i++) 
    {
        for (int j=0;j<rowLenght;j++) 
        {
            sum = sum + a;
        }
        double average = sum / rowLenght;
        int n = i + 1;
    }
    return sum;
}    
    

int n = GetDataFromUser ("Введите количество строк");
int m = GetDataFromUser ("Введите количество столбцов");
int [,] array = get2DDoubleArray (n,m,0,100);
print2DArray (array);
int AverageSumofNumbers = getAverageSum (array, n,m);
Console.WriteLine ($"Среднее арифметическое элементов в каждом столбце массива равна {AverageSumofNumbers}");


