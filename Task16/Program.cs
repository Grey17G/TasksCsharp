//Задача 16: Напишите программу, которая принимает на вход два числа и
//проверяет, является ли одно число квадратом другого.

//5, 25 -> да
//-4, 16 -> да
//25, 5 -> да
//8,9 -> нет

Console.WriteLine("введите первое число ");
int N1 = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("введите второе число ");
int N2 = Convert.ToInt32(Console.ReadLine()!);

if (N1 == N2 * N2 || N2 == N1 * N1)
{
    Console.WriteLine("является квадратом");
}
else
{
    Console.WriteLine("не является квадратом");
}