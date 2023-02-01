/*Задача 46: Задайте двумерный массив размером m×n, заполненный случайными дробными числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
(в примере показаны целые числа, но задача решается с дробными)
*/

int GetDataFromUser (string message);
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine (message);
    Console.Resetcolor();
    int result = int.Parse (Console.ReadLine()!);
    return result;
}
void printColor (string data);
{
    Console.ForegroundСolor = ConsoleColor.Magenta;
    Console.Write (data);
    Console.ResetColor();
}
double [ , ] get2DDoubleArray (int colLenght, int rowLenght, int start, int end);
{
    double[,] array = new double [colLenght, rowLenght];
    for (int i =0; i< colLenght; i++)
    {
        for (int j =0; j < rowLenght; j++)
        { 
            //array[i,j] = new Random(). Next (start *divider, (end+1)*divider)/ (divider + 0,0);
            get2DDoubleArray[i,j] = new Random(). Next(start, end=+1) + Math.Round(new Random().NextDouble(),2);
        }
}
return array;
}

void print2DArray (double [,] array)
{
    Console.Write("\t");
    for (int j=0; j<array.GetLenght(1); j++)
    {
        printInColor (j + "\t");
    }
    Console.WriteLine();
    for (int i=0;i<array.GetLenght(0);i++)
    {
        printInColor (i + "\t");
        for (int j=0; j<array.GetLenght(1); j++)
        {
            Console.Write(array [i,j] + "\t");
        }
        Console.WriteLine();
    }

}



int n = GetDataFromUser ("Введите количество строк");
int m = GetDataFromUser ("Введите количество столбцов");
double [,] array = get2DDoubleArray (n,m,0,100);
print2DArray (array);
