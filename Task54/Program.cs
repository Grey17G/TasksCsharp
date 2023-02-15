/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int getDataUser(string message)
{
    Console.WriteLine(message);
    int result = int.Parse (Console.ReadLine()!);
    return result;
}

int [,] get2DIntArray (int colLenght, int rowLenght, int start, int end)
{
    int [,] array = new int [colLenght, rowLenght];
    for (int i = 0; i < colLenght; i++)
    {
        for (int j = 0; j < rowLenght; j++)
        {
            array[i,j]= new Random (). Next(start, end+1);
        }
    }
    return array;
}

void print2DArray (int [,] array)
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + "\t");
        }
        Console.WriteLine ();
    }
}

void getSorted2DArray (int [,] array, int colLenght, int rowLenght)
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
        {
            for (int k=0; k< array.GetLength(1) -1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                int temp = array[i, k + 1];
                array[i, k + 1] = array[i, k];
                array[i, k] = temp;
                }
            } 
        } 
    }       
}

int n = getDataUser ("Введите количество cтрок");
int m = getDataUser ("Введите количество столбцов");
int [,] array = get2DIntArray (n,m,0,100);
print2DArray (array);
getSorted2DArray (array, n,m);
Console.WriteLine();
print2DArray (array);
