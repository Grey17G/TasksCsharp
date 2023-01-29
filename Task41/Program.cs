﻿/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int getDataFromUser (string message)
{
    Console.WriteLine (message);
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}

int[] GenerateArray (int lenght, string message)
{
    int [] array = new int [lenght];
    for (int i=0; i<lenght;i++)
    {
    Console.WriteLine (message);
    array[i] = int.Parse (Console.ReadLine()!);
    }
    return array;
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

int getNumbersOverZero (int []array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array [i]>0)
        {
            count+=1;
        }
    }
    return count;
}    


int lenght = getDataFromUser ("Введите размерность массива");
int [] array = GenerateArray (lenght, "Введите элемент массива");
PrintArray(array);
int count = getNumbersOverZero (array);
Console.WriteLine ($"Количество чисел больше нуля равна {count}");


