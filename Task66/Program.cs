/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
Решить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int getDataFromUser (string message)
{
    Console.WriteLine (message);
    int result = int.Parse (Console.ReadLine()!);
    return result;
}

int getSumRange (int start, int end)
{
    if (start > end)
    {
        return 0;
    }
    return start + getSumRange(start+1, end);
}



int DataUserStart = getDataFromUser ("Введите значение начала ряда");
int DataUserEnd = getDataFromUser ("Введите значение границы ряда");
int Sumofrage = getSumRange (DataUserStart, DataUserEnd);
Console.WriteLine(Sumofrage);