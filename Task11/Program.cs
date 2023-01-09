// Задача 11: Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа

// 456 -45
// 125 -15
// 546 -56

int GetNumberFromRange(int start, int end)
{
    int number = new Random(). Next(start, end + 1);
    return number;
}
int DeleteSecondDigit(int number)
{
    int digit3 = number % 10; 
    int digit1 = number / 100; 
    int result = digit1 *10 + digit3;
    return result;
}
int randomNumber = GetNumberFromRange(100,999);
int numberWithoutSecond = DeleteSecondDigit(randomNumber);
Console.WriteLine ($"Число {randomNumber} без второй цифры равно {numberWithoutSecond}");