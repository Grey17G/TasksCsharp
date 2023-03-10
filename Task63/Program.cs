/*Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
(Решено с помощью рекурсии)*/

int getFromUserData (string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine (message);
    Console.ResetColor();
    int result = int. Parse (Console.ReadLine()!);
    return result;
}

int UserNumber = getFromUserData ("Введите значение для границы ряда");

printRange (UserNumber);

void printRange (int N)
{
    if (N ==0)
    {
        return;
    }

    printRange(N-1);
    Console.Write(N + ",");
}