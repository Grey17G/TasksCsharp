/*Задача 26. Напишите программу, которая принимает на вход число
и выдает количество цифр в числе
456-3
78-2
89126-5
*/

int getUserData (string message)
{
    Console.WriteLine (message);
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}

int getNumberofDigit (int number)
{
    int NumberofDigit = 0;
    while (number >0)
    {
        number = number/10;
        NumberofDigit ++;
    }
    return NumberofDigit;
}

int number = getUserData ("Введите число");
int NumberofDigit = getNumberofDigit (number);
Console.WriteLine ($"Количество цифр в числе {number} равна {NumberofDigit}");

