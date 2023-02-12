/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

int GetDataFromUser (string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine (message);
    Console.ResetColor();
    int result = int.Parse (Console.ReadLine()!);
    return result;
}
void printInColor (string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write (data);
    Console.ResetColor();
}
int [,] get2DIntArray (int colLenght, int rowLenght, int start, int end)
{
    int[,] array = new int [colLenght, rowLenght];
    for (int i =0; i< colLenght; i++)
    {
        for (int j =0; j < rowLenght; j++)
        { 
            array [i,j] = i + j;
        }
    }
    return array;
}

void print2DArray (int [,] array)
{
    Console.Write(" \t");
    for (int j=0; j < array.GetLength(1); j++)
    {
        printInColor (j + "\t");
    }
    Console.WriteLine();
    for (int i=0;i < array.GetLength(0);i++)
    {
        printInColor (i + "\t");
        for (int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i,j] + "\t");
        }
        Console.WriteLine();
    }

}
int n = GetDataFromUser ("Введите количество строк");
int m = GetDataFromUser ("Введите количество столбцов");
int [,] array = get2DIntArray (n,m,0,100);
print2DArray (array);
