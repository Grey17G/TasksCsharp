/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/


int GetDataFromUser (string message)
{
    Console.WriteLine (message);
    int result = int.Parse (Console.ReadLine()!);
    return result;
}

int [ , ] get2DIntArray (int colLenght, int rowLenght, int start, int end)
{
    int[,] array = new int [colLenght, rowLenght];
    for (int i =0; i< colLenght; i++)
    {
        for (int j =0; j < rowLenght; j++)
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

void getValue (int [,] array, int colLenght, int rowLenght, int PositionA, int PositionB)
{
    if (PositionA> colLenght && PositionB >rowLenght)
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"Значение элемента строки {PositionA} и столбца {PositionB} равно {array [PositionA-1,PositionB -1]}");
    }
} 
    

int n = GetDataFromUser ("Введите количество строк");
int m = GetDataFromUser ("Введите количество столбцов");
int [,] array = get2DIntArray (n,m,0,100);
print2DArray (array);
int row = GetDataFromUser ("Введите координаты элемента по строке");
int col = GetDataFromUser ("Введите координаты элемента по столбцу");
getValue (array,n, m, row, col);

