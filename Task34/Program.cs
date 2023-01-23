// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] FillArray (int lenght, int start, int end)
{
    int [] result = new int [lenght];
    for(int i=0;i<lenght;i++)
    {
        result [i] = new Random (). Next (start, end +1);
    }
    return result;
}

int getUserData (string message)
{
    Console.WriteLine (message);
    int userData = int. Parse (Console.ReadLine()!);
    return userData;
}

void printArray (int[] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
    {
        Console.Write(array[i]);
        if(i<array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int getEvenNumbers (int [] array)
{
    int count = 0;
    for (int i =0; i <array.Length; i++)
    {
        if(array[i]%2==0)
        {
            count+=1;
        }
    }
    return count;
}

int lenght = getUserData ("Введите длину массива");
int [] array = FillArray (lenght, 100, 999);
printArray (array);
int count= getEvenNumbers(array);
Console.WriteLine ($"Количество четных чисел в массиве равна {count}");
