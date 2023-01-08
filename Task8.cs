// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write ("введите целое число ");
int N =int.Parse(Console.ReadLine()!);
int evenN = 2;

if (N>1)
{
    while (evenN <=N)
    {
        Console.Write(evenN  + " ");
        evenN = evenN + 2;
    }
}

