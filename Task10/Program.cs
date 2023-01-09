// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine ("введите трехзначное число");
int number = int.Parse (Console.ReadLine ()!);

int FindSecondDigit(int number)
{
    int result = (number/10)%10;
    return result;
}

int dig2 = FindSecondDigit(number);
Console.WriteLine ($"Вторая цифра числа {number} равно {dig2}");


