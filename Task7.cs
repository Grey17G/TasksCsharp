// Задача 7: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("введите число ");
int number = int.Parse(Console.ReadLine()!);

if (number<0)
{number = number*(-1);}
Console.WriteLine(number%10);

  
