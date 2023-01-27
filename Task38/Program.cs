/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double [] GenerateArray (int lenght, int start, int end)
{
   double[] array= new double [lenght];
    for (int i = 0; i<lenght; i++)
    {
        array [i] = new Random(). Next (start,end+1);
    }
    return array;
}

int getDataFromUser (string message)
{
    Console.WriteLine (message);
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;

}

void PrintArray (double [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
      Console.Write (array[i]);
      if (i<array.Length-1)
      {
        Console.Write (",");
      }
    } 
    Console.WriteLine("]");  
}

double getDifferenceMinAndMax (double [] array, int start, int end)
{
   double max= array[0];
   double min= max;
   double difference = 0;
   for (int i = 0; i < array.Length; i++)
   {
    if (array [i] < min)  min = array [i];
    if (array [i] > max) max = array [i];
    difference = max - min;
   }   
   return difference;
}   

int lenght = getDataFromUser ("Введите длину массива");
double [] array = GenerateArray (lenght, 1,50);
PrintArray(array);
double DifferenceMinAndMax = getDifferenceMinAndMax (array, 1, 50);
Console.WriteLine ($"Разница между максимальным и минимальным элементов массива равно {DifferenceMinAndMax}");



