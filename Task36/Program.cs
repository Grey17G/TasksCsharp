/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int [] GenerateArray (int lenght, int start, int end)
{
    int[] result= new int [lenght];
    for (int i = 0; i<lenght; i++)
    {
        result [i] = new Random(). Next (start,end+1);
    }
    return result;
}

int getDataFromUser (string message)
{
    Console.WriteLine (message);
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}

void PrintArray (int [] array)
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

int SumofOddNumbers (int [] array)
{
    int sum =0;
    for (int i = 0; i < array.Length; i++)
    {
        if ( i%2!=0)
        {
            sum= sum+array[i];
        }
    } 
    return sum;
}
 

int lenght = getDataFromUser ("Введите длину массива");
int[] array = GenerateArray (lenght, 0,10);
PrintArray(array);
int sum = SumofOddNumbers (array);
Console.WriteLine ($" Сумма нечетных элементов массива равно {sum}");


    


