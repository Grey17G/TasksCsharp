/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int getUserData (string message)
{
    Console.WriteLine (message);
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}

int getSumofDigit (int number)
{
    int Sum = 0;
    while (number >0)
    {
        Sum = Sum + number%10;
        number = number/10;
    }
    return Sum;
}

int number = getUserData ("Введите число");
int SumofDigit = getSumofDigit (number);
Console.WriteLine ($"Сумма цифр в числе {number} равна {SumofDigit}");
